using Application.DTOs.Exam;
using Application.DTOs.ExamScored;
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
                        .ThenInclude(bq => bq.Answers)
                .FirstOrDefaultAsync();

            if (exam == null) return null;

            //var now = DateTime.Now;

            //var examScored = new ExamScored
            //{
            //    UserId = userId,
            //    StartTime = now,
            //    SubmitedTime = null,
            //    Score = 0,
            //    ExamId = examId
            //};

            //_context.ExamssScoreds.Add(examScored);
            //await _context.SaveChangesAsync();

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
                    }).ToList() ?? new()
                }).ToList(),
                TotalTime = exam.TotalTime,
                //ExanScoredId = examScored.Id
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

    }
}
