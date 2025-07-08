using Application.DTOs.Answer;
using Application.DTOs.Exam;
using Application.DTOs.ExamScored;
using Application.DTOs.Question;
using Application.Interface.IRepository;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Persistence.DatabaseConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ExamRepository : Repository<Exam>, IExamRepository
    {
        public ExamRepository(AskiverseContext context) : base(context)
        {
        }

		public async Task<List<Exam>> GetAllExams()
        {
            var exam = await _context.Examss.Include(e => e.ExamScoreds).ToListAsync();
            return exam;
        }

        public async Task<int> CreateExamScored(int examId, string userId)
        {
            var now = DateTime.Now;
            var examScored = new ExamScored
            {
                UserId = userId,
                StartTime = now,
                SubmitedTime = null,
                Score = 0,
                CreatedAt = now,
                UpdatedAt = now,
                DeletedAt = DateTime.MinValue, 
                ExamId = examId
            };

            _context.ExamssScoreds.Add(examScored);
            await _context.SaveChangesAsync();
            return examScored.Id;
        }

        public async Task<ExamTakeDTO?> GetExamTakeById(int examId, string userId)
        {
            var exam = await _context.Examss
                .Where(e => e.Id == examId)
                .Include(e => e.QuestionExam)
                    .ThenInclude(qe => qe.BankQuestion)
                        .ThenInclude(bq => bq.QuestionType)
				.Include(e => e.QuestionExam)
		            .ThenInclude(qe => qe.BankQuestion)
			            .ThenInclude(bq => bq.Answers)
                .FirstOrDefaultAsync();

            if (exam == null) return null;

            return new ExamTakeDTO
            {
                Id = exam.Id,
                Title = exam.Title,
                Questions = exam.QuestionExam.Select(q => new Application.DTOs.Question.QuestionTakeDTO
                {
                    Id = q.Id,
                    Content = q.Content ?? q.BankQuestion?.Content ?? "",
                    Answers = q.BankQuestion?.Answers.Select(a => new Application.DTOs.Answer.AnswerDTO
                    {
                        Id = a.Id,
                        AnswerText = a.AnswerText ?? ""
                    }).ToList() ?? new(),
                    QuestionTypeId = q.QuestionTypeId
                }).ToList(),
                TotalTime = exam.TotalTime,
                //QuestionTypes = exam.QuestionExam.Select(qe => qe.BankQuestion?.QuestionType)
                //.Where(qt => qt != null)
                //.DistinctBy(qt => qt!.Id)
                //.Select(qt => qt!)
                //.ToList()
            };
        }
        public async Task<int> SubmitExamAsync(ExamSubmitDTO dto, int ExamScoredId)
        {
            var exam = await _context.Examss
                .Include(e => e.QuestionExam)
                    .ThenInclude(q => q.BankQuestion)
                        .ThenInclude(b => b.Answers)
                .FirstOrDefaultAsync(e => e.Id == dto.ExamId);

            var examScored = await _context.ExamssScoreds.FirstOrDefaultAsync(es => es.Id == ExamScoredId);
            var now = DateTime.Now;
            examScored!.SubmitedTime = now;


            int totalQuestions = exam!.QuestionExam.Count;
            int correctCount = 0;

            _context.ExamssScoreds.Update(examScored);
            await _context.SaveChangesAsync();

            foreach (var submitted in dto.Answers)
            {
                if (submitted.AnswerId <= 0) continue;

                var question = exam.QuestionExam.FirstOrDefault(q => q.Id == submitted.QuestionId);
                var isCorrect = question?.BankQuestion?.Answers
                    .Any(a => a.Id == submitted.AnswerId && a.IsCorrected) ?? false;

                if (isCorrect) correctCount++;

                var answered = new ExamAnswered
                {
                    ExamScoredId = examScored.Id,
                    AnswerId = submitted.AnswerId,
                    IsCorrected = isCorrect,
                    QuestionExamId = submitted.QuestionId
                };

                _context.ExamAnswereds.Add(answered);
            }

            examScored.Score = Math.Round(10.0 * correctCount / totalQuestions, 2);
            await _context.SaveChangesAsync();
            return examScored.Id;
        }
        public async Task<Exam?> GetByIdAsync(int id)
        {
            return await _context.Examss.FindAsync(id);
        }

        public async Task<IEnumerable<Exam>> GetByPremiumUserIdAsync(string premiumUserId)
        {
            return await _context.Examss
                .Where(e => e.PremiumUserId == premiumUserId)
                .ToListAsync();
        }
        public async Task<Exam?> GetExamWithRelationsAsync(int examId)
        {
            return await _context.Examss
                .Include(e => e.ExamAccesses)
                .Include(e => e.QuestionExam)
                .Include(e => e.ExamScoreds)
                .FirstOrDefaultAsync(e => e.Id == examId);
        }
        public async Task<ExamFlashcardDTO?> GetExamForPreview(int examId, string userId)
        {
            var exam = await _context.Examss
                .Where(e => e.Id == examId)
                .Include(e => e.QuestionExam)
                    .ThenInclude(qe => qe.BankQuestion)
                        .ThenInclude(bq => bq.Answers)
                .FirstOrDefaultAsync();

            if (exam == null) return null;

            return new ExamFlashcardDTO
            {
                Id = exam.Id,
                Title = exam.Title,
                Questions = exam.QuestionExam.Select(q => new QuestionFlashcardDTO
                {
                    Id = q.Id,
                    Content = q.Content ?? q.BankQuestion?.Content ?? "",
                    QuestionTypeId = q.BankQuestion?.QuestionTypeId ?? 0,
                    Answers = q.BankQuestion?.Answers.Select(a => new AnswerDetailDTO
                    {
                        Id = a.Id,
                        AnswerText = a.AnswerText ?? "",
                        IsCorrected = a.IsCorrected,
                        MatchingPairKey = a.MatchingPairKey
                    }).ToList() ?? new()
                }).ToList()
            };
        }
        public async Task<ExamFlashcardDTO?> GetExamForFlashcard(int examId, string userId)
        {
            var exam = await _context.Examss
                .Where(e => e.Id == examId)
                .Include(e => e.QuestionExam)
                    .ThenInclude(qe => qe.BankQuestion)
                        .ThenInclude(bq => bq.Answers)
                .FirstOrDefaultAsync();

            if (exam == null) return null;

            var questions = exam.QuestionExam.Select(q => new QuestionFlashcardDTO
            {
                Id = q.Id,
                Content = q.Content ?? q.BankQuestion?.Content ?? "",
                QuestionTypeId = q.BankQuestion?.QuestionTypeId ?? 0,
                Answers = q.BankQuestion?.Answers.Select(a => new AnswerDetailDTO
                {
                    Id = a.Id,
                    AnswerText = a.AnswerText ?? "",
                    IsCorrected = a.IsCorrected,
                    MatchingPairKey = a.MatchingPairKey
                }).ToList() ?? new()
            }).ToList();

            // ✅ Shuffle tại chỗ — không dùng extension
            ShuffleList(questions);

            return new ExamFlashcardDTO
            {
                Id = exam.Id,
                Title = exam.Title,
                Questions = questions
            };

            // Hàm trộn tại chỗ (local method)
            void ShuffleList<T>(IList<T> list)
            {
                Random rng = new Random();
                int n = list.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    (list[k], list[n]) = (list[n], list[k]);
                }
            }
        }

    }
}
