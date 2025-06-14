using Application.DTOs.Exam;
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
            await _unitOfWork.CommitAsync();  // Commit để EF gán exam.Id

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

        public async Task<List<BankQuestion>> SearchBankQuestionsAsync(SearchBankQuestionFilter filter)
        {
            var query = _unitOfWork.BankQuestions
                .Query()
                .Include(q => q.QuestionType)
                .Include(q => q.Level)
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
        public async Task<List<ExamDTO>> GetAllExams()
        {
            var exams = await _unitOfWork.Exams.GetAllExams();
            return _mapper.Map<List<ExamDTO>>(exams);
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


    }

}
