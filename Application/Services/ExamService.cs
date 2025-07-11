using Application.DTOs.Commons;
using Application.DTOs.Exam;
using Application.DTOs.ExportDocx;
using Application.DTOs.Favourite;
using Application.DTOs.Question;
using Application.DTOs.Question.GenerateAI;
using Application.DTOs.Subject;
using Application.DTOs.ViewModel;
using Application.Interface.IExternalService;
using Application.Interface.IServices;
using Application.Paginated;
using Application.UnitOfWork;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class ExamService : Service, IExamService
    {
        private readonly IBankQuestionService _bankQuestionService;
        private readonly IUserContextService _userContext;
        private readonly IExportFileDocxService _exportFileDocxService;
        public ExamService(IUnitOfWork unitOfWork, IMapper mapper,
            IBankQuestionService bankQuestionService,
            IUserContextService userContext,
            IExportFileDocxService exportFileDocxService) : base(unitOfWork, mapper)
        {
            _bankQuestionService = bankQuestionService;
            _userContext = userContext;
            _exportFileDocxService = exportFileDocxService;
        }
        public async Task<int> CreateExamAsync(CreateExamDTO dto)
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
                TotalTime = TimeSpan.FromMinutes(dto.TotalTime),
                UpdatedAt = DateTime.UtcNow,
                DeletedAt = DateTime.MinValue
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
                    IsPublic = true,
                    UpdatedAt = DateTime.UtcNow,
                    DeletedAt = DateTime.MinValue
                };
                await _unitOfWork.QuestionExams.AddAsync(questionExam);
            }

            try
            {
                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Lỗi khi CommitAsync (thêm QuestionExams): " + ex.ToString());
                throw;
            }
            return exam.Id;
        }


        public async Task<List<BankQuestion>> SearchBankQuestionsAsync(SearchBankQuestionFilter filter, string? PremiumUserId)
        {
            IQueryable<BankQuestion> query = _unitOfWork.BankQuestions
     .Query()
     .Include(q => q.QuestionType)
     .Include(q => q.Level)
    .Where(q => q.PremiumUserId != null && q.PremiumUserId == PremiumUserId)

     .OrderByDescending(q => q.CreatedAt);

            if (filter.QuestionTypeId.HasValue)
                query = query.Where(q => q.QuestionTypeId == filter.QuestionTypeId.Value);

            if (filter.LevelId.HasValue)
                query = query.Where(q => q.LevelId == filter.LevelId.Value);

          

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
                include: q => q
                    .Include(x => x.Answers)
                    .Include(x => x.QuestionType)
            );

            if (question == null) return null;

            return new QuestionDetailDTO
            {
                Id = question.Id,
                Content = question.Content,
                QuestionTypeId = question.QuestionTypeId,
                QuestionTypeName = question.QuestionType?.Name,
                Answers = question.Answers.Select(a => new AnswerDTO
                {
                    Id = a.Id,
                    AnswerText = a.AnswerText,
                    IsCorrected = a.IsCorrected,
                    MatchingPairKey = a.MatchingPairKey
                }).ToList()
            };
        }
        public async Task<ExamSubjectViewModel> GetAllExams(bool isPublic, string userId, string subjectId, string? questionCount, string? sortOrder, string? keyword, bool isFavourite = false, int pageIndex = 1, int pageSize = 5)
        {
            var subjects = await _unitOfWork.Subjects.Query().ToListAsync();
            if (subjects.Count == 0) throw new Exception("Không có chủ đề nào!");

            int? subjectIdInt = null;
            if (!string.IsNullOrEmpty(subjectId) && int.TryParse(subjectId, out int parsedInt))
            {
                subjectIdInt = parsedInt;
            }
            int? questionCountInt = null;
            if (!string.IsNullOrEmpty(questionCount) && int.TryParse(questionCount, out int parsedQuestionCount))
            {
                questionCountInt = parsedQuestionCount;
            }

            var examQuery = _unitOfWork.Exams
                     .Query()
                     .Include(e => e.FavouritedByUsers)
                     .Include(e => e.ExamAccesses)
                     .Include(e => e.ExamScoreds)
                     .Include(e => e.PremiumUser)
                        .ThenInclude(pu => pu.BasicUser)
                     .Where(e => e.DeletedAt == DateTime.MinValue || e.DeletedAt == null)
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

            if (questionCountInt.HasValue)
            {
                examQuery = examQuery.Where(e => e.TotalQuestion == questionCountInt);
            }

            if (!string.IsNullOrEmpty(keyword))
            {
                examQuery = examQuery.Where(e => e.Title.Contains(keyword));
            }

            if (!string.IsNullOrEmpty(sortOrder))
            {
                if (sortOrder == "newest")
                    examQuery = examQuery.OrderByDescending(e => e.CreatedAt);
                else
                    examQuery = examQuery.OrderBy(e => e.CreatedAt);
            }

            //var exams = await examQuery.ToListAsync();

            var paginated = await PaginatedList<Exam>.CreateAsync(examQuery, pageIndex, pageSize);

            if (!paginated.Any())
            {
                if (isFavourite)
                    throw new Exception("Bạn chưa thêm đề nào vào yêu thích!");
                else if (isPublic)
                    throw new Exception("Không có dữ liệu!");
                else
                    throw new Exception("Không có đề nào phù hợp!");
            }

            return new ExamSubjectViewModel
            {
                Exams = paginated.Select(e => new ExamDTO
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

                    CanEdit = e.PremiumUserId == userId || e.ExamAccesses.Any(a => a.userId == userId && a.Permission),
                    HasBeenScored = e.ExamScoreds.Any(),
                    PremiumUser = e.PremiumUser,
                }).ToList(),

                Subjects = _mapper.Map<List<SubjectDTO>>(subjects),
                Pagination = new DTOs.Pagination.PaginationDTO
                {
                    CurrentPage = paginated.PageIndex,
                    TotalPages = paginated.TotalPages,
                    PageSize = paginated.PageSize,
                    TotalCount = paginated.TotalCount,
                }
            };
        }

        public async Task<ExamTakeDTO?> GetExamTakeById(int examId, string userId)
        {
            var exam = await _unitOfWork.Exams.GetExamTakeById(examId, userId);
            return exam;
        }
        public async Task<ExamFlashcardDTO?> GetExamForFlashcard(int examId, string userId)
        {
            var exam = await _unitOfWork.Exams.GetExamForFlashcard(examId, userId);
            return exam;
        }
        public async Task<ExamFlashcardDTO?> GetExamForPreview(int examId, string userId)
        {
            var exam = await _unitOfWork.Exams.GetExamForFlashcard(examId, userId);
            return exam;
        }
        public async Task<int> SubmitExamAsync(ExamSubmitDTO dto, int ExamScoredId)
        {
            var examScoredId = await _unitOfWork.Exams.SubmitExamAsync(dto, ExamScoredId);
            return examScoredId;
        }

        public async Task<int> CreateExamScoredAsync(int examId, string userId)
        {
            var examScored = await _unitOfWork.Exams.CreateExamScored(examId, userId);
            return examScored;
        }

        public async Task<bool> UpdateBankQuestionAsync(UpdateBankQuestionDTO dto)
        {
            var question = await _unitOfWork.BankQuestions.GetByIdWithAnswersAsync(dto.Id);
            if (question == null) return false;

            // Chỉ cập nhật các trường cho phép
            question.Content = dto.Content;
            question.LevelId = dto.LevelId;
            question.IsPublic = dto.IsPublic;

            // Xử lý danh sách đáp án
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

        public async Task<List<int>> GetRandomQuestionIdsAsync(int count, SearchBankQuestionFilter filter, string? premiumUserId)
        {
            return await _unitOfWork.BankQuestions.GetRandomQuestionIdsAsync(count, filter, premiumUserId);
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

            bool isOwner = exam.PremiumUserId == userId;

            if (isOwner)
            {
                // 🛑 Không cho xóa nếu đã có kết quả làm bài
                if (exam.ExamScoreds.Any())
                    throw new InvalidOperationException("Không thể xóa vì đề đã được làm.");

                // ✅ Soft delete: gán DeletedAt
                exam.DeletedAt = DateTime.UtcNow;

                foreach (var access in exam.ExamAccesses)
                    access.DeletedAt = DateTime.UtcNow;

                foreach (var q in exam.QuestionExam)
                    q.DeletedAt = DateTime.UtcNow;
            }
            else
            {
                // ✅ Là người được chia sẻ (và có quyền xóa)
                var access = exam.ExamAccesses.FirstOrDefault(ea => ea.userId == userId && ea.Permission);
                if (access == null)
                    throw new InvalidOperationException("Bạn không có quyền xóa đề này.");

                // ❌ Xóa cứng access (chỉ với người được chia sẻ)
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
                UpdatedAt = DateTime.UtcNow,
                DeletedAt = DateTime.MinValue,
                Answers = dto.Answers.Select(a => new Answer
                {
                    AnswerText = a.AnswerText!,
                    IsCorrected = a.IsCorrected,
                    UpdatedAt = DateTime.UtcNow,
                    DeletedAt = DateTime.MinValue,
                    MatchingPairKey = a.MatchingPairKey
                }).ToList()
            };

            await _unitOfWork.BankQuestions.AddAsync(question);
            await _unitOfWork.CompleteAsync();
        }
        public async Task<EditExamDTO> GetExamForEditAsync(int examId)
        {
            var exam = await _unitOfWork.Exams.GetExamWithRelationsAsync(examId);
            if (exam == null) throw new Exception("Không tìm thấy đề thi.");

            var selectedQuestionIds = exam.QuestionExam.Select(q => q.BankQuestionId).ToList();

            return new EditExamDTO
            {
                Id = exam.Id,
                Title = exam.Title,
                Description = exam.Description,
                SourceText = exam.SourceText,
                SubjectId = exam.SubjectId ?? 0,
                IsPublic = exam.IsPublic,
                TotalQuestion = exam.TotalQuestion,
                TotalTime = (int)exam.TotalTime.TotalMinutes,
                SelectedQuestionIds = selectedQuestionIds

            };
        }
        public async Task<bool> UpdateExamAsync(EditExamDTO dto)
        {
            var exam = await _unitOfWork.Exams.GetExamWithRelationsAsync(dto.Id);
            if (exam == null)
                throw new Exception("Không tìm thấy đề thi.");


            if (exam.ExamScoreds.Any())
                throw new InvalidOperationException("Không thể chỉnh sửa vì đề đã được làm.");

            if (dto.SelectedQuestionIds.Count != dto.TotalQuestion)
                throw new ArgumentException("Số câu hỏi đã chọn không khớp với tổng số câu hỏi.");


            _unitOfWork.ExamAccess.RemoveRange(exam.ExamAccesses);
            _unitOfWork.QuestionExams.RemoveRange(exam.QuestionExam);

            // Cập nhật thông tin đề
            exam.Title = dto.Title;
            exam.Description = dto.Description;
            exam.SourceText = dto.SourceText;
            exam.SubjectId = dto.SubjectId;
            exam.IsPublic = dto.IsPublic;
            exam.TotalQuestion = dto.TotalQuestion;
            exam.UpdatedAt = DateTime.UtcNow;
            exam.TotalTime = TimeSpan.FromMinutes(dto.TotalTime);
            // Thêm mới các câu hỏi
            foreach (var questionId in dto.SelectedQuestionIds)
            {
                var question = await _unitOfWork.BankQuestions.GetSingle(q => q.Id == questionId);
                if (question == null)
                    throw new Exception($"Không tìm thấy câu hỏi có ID {questionId}");

                var questionExam = new QuestionExam
                {
                    ExamId = exam.Id,
                    BankQuestionId = questionId,
                    QuestionTypeId = question.QuestionTypeId,
                    LevelId = question.LevelId,
                    UpdatedAt = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow,
                    DeletedAt = DateTime.MinValue,
                    IsPublic = true
                };

                await _unitOfWork.QuestionExams.AddAsync(questionExam);
            }

            try
            {
                await _unitOfWork.CompleteAsync();
            }
            catch (DbUpdateException ex)
            {
                var innerMessage = ex.InnerException?.Message ?? ex.Message;
                throw new Exception("Lỗi khi lưu thay đổi: " + innerMessage, ex);
            }

            return true;
        }

        public async Task<List<SimpleQuestionDto>> GetQuestionsByIdsAsync(List<int> questionIds)
        {
            var questions = await _unitOfWork.BankQuestions.FindAsync(q => questionIds.Contains(q.Id));

            return questions.Select(q => new SimpleQuestionDto
            {
                Id = q.Id,
                Content = q.Content
            }).ToList();
        }

        public async Task<IdResponse> SaveExamGeneratedByAi(SaveExamDTO dto)
        {
            var userId = _userContext.GetUserId();
            var questions = await _bankQuestionService.CreateQuestionByAI(dto.Questions);
            var exam = new Exam
            {
                Title = dto.ExamData.Title,
                SourceText = dto.ExamData.SourceText,
                Description = dto.ExamData.Description,
                SubjectId = dto.ExamData.SubjectId,
                PremiumUserId = userId,
                IsPublic = dto.ExamData.IsPublic,
                TotalTime = TimeSpan.FromMinutes(dto.ExamData.TotalTime),
                TotalQuestion = dto.ExamData.TotalQuestion,
                CreatedAt = DateTime.Now
            };
            await _unitOfWork.Exams.AddAsync(exam);
            await _unitOfWork.CommitAsync();

            foreach (var question in questions)
            {

                var questionExam = new QuestionExam
                {
                    ExamId = exam.Id,
                    BankQuestionId = question.Id,
                    QuestionTypeId = question.QuestionTypeId,
                    LevelId = question.LevelId,
                    CreatedAt = DateTime.UtcNow,
                    IsPublic = true,
                    UpdatedAt = DateTime.UtcNow,
                    DeletedAt = DateTime.MinValue
                };
                await _unitOfWork.QuestionExams.AddAsync(questionExam);
            }

            try
            {
                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Lỗi khi CommitAsync (thêm QuestionExams): " + ex.ToString());
                throw;
            }
            return IdResponse.SuccessResponse(exam.Id, "Tạo thành công");
        }

        public async Task<byte[]> ExportExamToDocxFile(long examId)
        {
            var questions = await _unitOfWork.QuestionExams
                .GetInstance()
                .Where(e => e.ExamId == examId)
                .Select(e => new QuestionTemplateDto
                {
                    Content = e.BankQuestion.Content,
                    Answers = e.BankQuestion!.Answers
                                .Where(a => a.BankQuestionId == e.BankQuestionId)
                                .Select(a => a.AnswerText)
                                .ToList()
                })
                .ToListAsync();
            var exam = new ExamTemplateDto { Questions = questions };

            var data = _exportFileDocxService.Export(exam);
            return data;
        }
    }
}


