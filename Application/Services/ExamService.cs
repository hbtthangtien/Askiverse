using Application.DTOs.Exam;
using Application.DTOs.Favourite;
using Application.DTOs.Question;
using Application.DTOs.Subject;
using Application.DTOs.ViewModel;
using Application.Interface.IServices;
using Application.UnitOfWork;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class ExamService : Service, IExamService
    {
        public ExamService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<bool> CreateExamAsync(CreateExamDTO dto)
        {
            if (dto.SelectedQuestionIds.Count != dto.TotalQuestion)
                throw new ArgumentException("Số câu hỏi đã chọn không khớp với tổng số câu hỏi.");

            var exam = new Exam
            {
                Title = dto.Title,
                SourceText = dto.SourceText,
                Description = dto.Description,
                SubjectId = dto.SubjectId,
                PremiumUserId = dto.PremiumUserId,
                IsPublic = dto.IsPublic,
                TotalQuestion = dto.TotalQuestion,
                CreatedAt = DateTime.UtcNow,
                TotalTime = TimeSpan.FromMinutes(50)
            };

            await _unitOfWork.Exams.AddAsync(exam);
            await _unitOfWork.CommitAsync();  

            foreach (var questionId in dto.SelectedQuestionIds)
            {
                var question = await _unitOfWork.BankQuestions.GetSingle(q => q.Id == questionId);

                if (question == null)
                    throw new ArgumentException($"Câu hỏi với ID {questionId} không tồn tại.");

                var questionExam = new QuestionExam
                {
                    ExamId = exam.Id,
                    BankQuestionId = questionId,
                    QuestionTypeId = question.QuestionTypeId,
                    LevelId = question.LevelId,
                    CreatedAt = DateTime.UtcNow,
                    IsPublic = true
                };
                await _unitOfWork.QuestionExams.AddAsync(questionExam);
            }

            await _unitOfWork.CommitAsync();

            return true;
        }
       

        public async Task<List<BankQuestion>> SearchBankQuestionsAsync(SearchBankQuestionFilter filter, string? PremiumUserId)
        {
            var query = _unitOfWork.BankQuestions
                .Query()
                .Include(q => q.QuestionType)
                .Include(q => q.Level)
                .Where(q => q.PremiumUserId == PremiumUserId || q.IsPublic == true)
                .AsQueryable();

            if (filter.QuestionTypeId.HasValue)
                query = query.Where(q => q.QuestionTypeId == filter.QuestionTypeId.Value);

            if (filter.LevelId.HasValue)
                query = query.Where(q => q.LevelId == filter.LevelId.Value);

            if (filter.IsPublic.HasValue)
                query = query.Where(q => q.IsPublic == filter.IsPublic.Value);

            if (!string.IsNullOrWhiteSpace(filter.Keyword))
            {
                var keywordLower = filter.Keyword.ToLower();
                query = query.Where(q => q.Content != null && q.Content.ToLower().Contains(keywordLower));
            }

            return await query.ToListAsync();
        }





        public async Task<List<Subject>> GetAllSubjectsAsync()
        {
            var subjects = await _unitOfWork.Subjects.GetAllAsync();
            return subjects.ToList();
        }
        public async Task<List<QuestionType>> GetAllQuestionTypesAsync()
        {
            return await _unitOfWork.QuestionTypes.Query().ToListAsync();
        }

        public async Task<List<Level>> GetAllLevelsAsync()
        {
            return await _unitOfWork.Levels.Query().ToListAsync();
        }

        public async Task<QuestionDetailDTO?> GetQuestionDetailAsync(int questionId)
        {
            var question = await _unitOfWork.BankQuestions.GetSingle(
                q => q.Id == questionId,
                include: q => q.Include(x => x.Answers)
            );

            if (question == null) return null;

            return new QuestionDetailDTO
            {
                Id = question.Id,
                Content = question.Content,
                Answers = question.Answers.Select(a => new AnswerDTO
                {
                    Id = a.Id,
                    AnswerText = a.AnswerText,
                    IsCorrected = a.IsCorrected
                }).ToList()
            };
        }
        public async Task<ExamSubjectViewModel> GetAllExams(bool isPublic, string userId, string subjectId, bool isFavourite = false)
        {
            var subjects = await _unitOfWork.Subjects.Query().ToListAsync();
            if (subjects.Count == 0) throw new Exception("Không có chủ đề nào!");

            int? subjectIdInt = null;
            if(!string.IsNullOrEmpty(subjectId) && int.TryParse(subjectId, out int parsedInt))
            {
                subjectIdInt = parsedInt;
            }

            var examQuery = _unitOfWork.Exams
                     .Query()
                     .Include(e => e.FavouritedByUsers)
                     .Include(e => e.ExamAccesses) 
                     .AsQueryable();
            
            if (isFavourite)
            {
				examQuery = examQuery.Where(e => e.FavouritedByUsers.Any(f => f.UserId == userId));
			}
            else
            {
				if (isPublic == true)
					examQuery = examQuery.Where(e => e.IsPublic == true || e.ExamAccesses.Any(a => a.userId == userId));
				else if (isPublic == false)
					examQuery = examQuery.Where(e => e.PremiumUserId == userId);
			}

            if (subjectIdInt.HasValue)
            {
                examQuery = examQuery.Where(e => e.SubjectId == subjectIdInt);
            }

            var exams = await examQuery.ToListAsync();
            if(exams.Count == 0)
            {
                if (isFavourite)
                    throw new Exception("Hiện tại không có đề chung phù hợp với bộ lọc!");
                else if (isPublic)
                    throw new Exception("Bạn chưa tạo đề nào phù hợp với bộ lọc!");
                else
					throw new Exception("Bạn chưa tạo đề nào phù hợp với bộ lọc!");
			}

            return new ExamSubjectViewModel
            {
                Exams = exams.Select(e => new ExamDTO
                {
                    Id = e.Id,
                    Title = e.Title,
                    Description = e.Description,
                    SourceText = e.SourceText,
                    CreatedAt = e.CreatedAt,
                    TotalQuestion = e.TotalQuestion,
                    FavouritedByUsers = e.FavouritedByUsers
        .Select(f => new FavouriteDTO
        {
            UserId = f.UserId,
            ExamId = f.ExamId
        }).ToList(),
                    // ⬇️ Thêm dòng này
                    CanEdit = e.PremiumUserId == userId || e.ExamAccesses.Any(a => a.userId == userId && a.Permission)
                }).ToList(),

                Subjects = _mapper.Map<List<SubjectDTO>>(subjects)
            };
        }

        public async Task<ExamTakeDTO?> GetExamTakeById(int examId, string userId)
        {
            var exam = await _unitOfWork.Exams.GetExamTakeById(examId, userId);
            return exam;
        }

        public async Task<int> SubmitExamAsync(ExamSubmitDTO dto, int ExamScoredId)
        {
            var examScoredId = await _unitOfWork.Exams.SubmitExamAsync(dto, ExamScoredId);
            return examScoredId;
        }

        public async Task<bool> UpdateBankQuestionAsync(UpdateBankQuestionDTO dto)
        {
            var question = await _unitOfWork.BankQuestions.GetByIdWithAnswersAsync(dto.Id);



            if (question == null) return false;

            question.Content = dto.Content;
            question.QuestionTypeId = dto.QuestionTypeId;
            question.LevelId = dto.LevelId;
            question.IsPublic = dto.IsPublic;

            // Xử lý đáp án
            foreach (var ans in dto.Answers)
            {
                if (ans.Id.HasValue && ans.IsDeleted)
                {
                    var toRemove = question.Answers.FirstOrDefault(a => a.Id == ans.Id.Value);
                    if (toRemove != null)
                        _unitOfWork.Answers.Remove(toRemove);


                }

                else if (ans.Id.HasValue)
                {
                    var toUpdate = question.Answers.FirstOrDefault(a => a.Id == ans.Id.Value);
                    if (toUpdate != null)
                    {
                        toUpdate.AnswerText = ans.AnswerText;
                        toUpdate.IsCorrected = ans.IsCorrected;
                        toUpdate.MatchingPairKey = ans.MatchingPairKey;
                    }
                }
                else if (!ans.IsDeleted)
                {
                    question.Answers.Add(new Answer
                    {
                        AnswerText = ans.AnswerText,
                        IsCorrected = ans.IsCorrected,
                        MatchingPairKey = ans.MatchingPairKey
                    });
                }
            }

            await _unitOfWork.CompleteAsync();
            return true;
        }
        public async Task<UpdateBankQuestionDTO?> GetBankQuestionByIdAsync(int id)
        {
            var question = await _unitOfWork.BankQuestions.GetByIdWithAnswersAsync(id);
            if (question == null) return null;

            return new UpdateBankQuestionDTO
            {
                Id = question.Id,
                Content = question.Content,
                QuestionTypeId = question.QuestionTypeId,
                LevelId = question.LevelId,
                IsPublic = question.IsPublic,
                Answers = question.Answers.Select(a => new UpdateAnswerDTO
                {
                    Id = a.Id,
                    AnswerText = a.AnswerText,
                    IsCorrected = a.IsCorrected,
                    MatchingPairKey = a.MatchingPairKey
                }).ToList(),

                QuestionTypeName = question.QuestionType?.Name,
                LevelName = question.Level?.DisplayName
            };
        }

        public async Task<List<int>> GetRandomQuestionIdsAsync(int count, SearchBankQuestionFilter filter, string? PremiumUserId)
        {
            return await _unitOfWork.BankQuestions.GetRandomQuestionIdsAsync(count, filter, PremiumUserId);
        }
        public async Task<List<ExamDTO>> GetExamsByPremiumUserIdAsync(string premiumUserId)
        {
            // Kiểm tra xem user có phải premium hay không
            var premiumUser = await _unitOfWork.PremiumUsers
                .FindAsync(p => p.UserId == premiumUserId && p.IsActive);

            if (premiumUser == null)
                return new List<ExamDTO>(); // Không phải premium → không có đề

            var exams = await _unitOfWork.Exams.GetByPremiumUserIdAsync(premiumUserId);

            return exams.Select(e => new ExamDTO
            {
                Id = e.Id,
                Title = e.Title
            }).ToList();
        }


        public async Task<ResultDTO> GrantExamAccessAsync(GrantExamAccessDTO dto, string premiumUserId)
        {
            var user = await _unitOfWork.BasicUsers.GetByEmailAsync(dto.Email);
            if (user == null)
                return ResultDTO.Fail("Email không tồn tại.");

            var exam = await _unitOfWork.Exams.GetByIdAsync(dto.ExamId);
            if (exam == null || exam.PremiumUserId != premiumUserId)
                return ResultDTO.Fail("Không tìm thấy đề thi hoặc không có quyền.");

            var access = new ExamAccess
            {
                userId = user.Id,
                ExamId = exam.Id,
                AccessDate = DateTime.UtcNow,
                Permission = dto.Permission
            };

            await _unitOfWork.ExamAccess.AddAsync(access);
            await _unitOfWork.CompleteAsync();

            return ResultDTO.Success("Cấp quyền thành công.");
        }
        public async Task<bool> DeleteExamAsync(int examId, string userId)
        {
            var exam = await _unitOfWork.Exams.GetExamWithRelationsAsync(examId);
            if (exam == null) return false;

            // 🧠 Nếu là chủ sở hữu -> xóa toàn bộ
            if (exam.PremiumUserId == userId)
            {
                if (exam.ExamScoreds.Any())
                    throw new InvalidOperationException("Không thể xóa vì đề đã được làm.");

                _unitOfWork.ExamAccess.RemoveRange(exam.ExamAccesses);
                _unitOfWork.QuestionExams.RemoveRange(exam.QuestionExam);
                _unitOfWork.Exams.Remove(exam);
            }
            else
            {
                // 🔐 Nếu là người được chia sẻ và có quyền chỉnh sửa -> chỉ xóa quyền truy cập
                var access = exam.ExamAccesses.FirstOrDefault(ea => ea.userId == userId && ea.Permission);
                if (access == null)
                    throw new InvalidOperationException("Bạn không có quyền xóa đề này.");

                _unitOfWork.ExamAccess.Remove(access);
            }

            await _unitOfWork.CompleteAsync();
            return true;
        }

        public async Task CreateBankQuestionAsync(CreateBankQuestionDTO dto)
        {
            var question = new BankQuestion
            {
                Content = dto.Content!,
                QuestionTypeId = dto.QuestionTypeId,
                LevelId = dto.LevelId,
                PremiumUserId = dto.PremiumUserId,
                IsPublic = dto.IsPublic,
                CreatedAt = DateTime.UtcNow,
                Answers = dto.Answers.Select(a => new Answer
                {
                    AnswerText = a.AnswerText!,
                    IsCorrected = a.IsCorrected,
                    MatchingPairKey = a.MatchingPairKey
                }).ToList()
            };

            await _unitOfWork.BankQuestions.AddAsync(question);
            await _unitOfWork.CompleteAsync();
        }

    }

}
