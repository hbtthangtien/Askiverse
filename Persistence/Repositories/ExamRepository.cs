using Application.DTOs.Exam;
using Application.Interface.IRepository;
using Domain.Entities;
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

        public async Task<ExamTakeDTO?> GetExamTakeById(int examId)
        {
            var exam = await _context.Examss
                .Where(e => e.Id == examId)
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
                    }).ToList() ?? new()
                }).ToList(),
                TotalTime = exam.TotalTime,
            };
		}

        public async Task<int> SubmitExamAsync(ExamSubmitDTO dto, string userId)
        {
            var exam = await _context.Examss
                .Include(e => e.QuestionExam)
                    .ThenInclude(q => q.BankQuestion)
                        .ThenInclude(b => b.Answers)
                .FirstOrDefaultAsync(e => e.Id == dto.ExamId);


            var now = DateTime.Now;
            int totalQuestions = exam.QuestionExam.Count;
            int correctCount = 0;

            var examScored = new ExamScored
            {
                UserId = userId,
                StartTime = now,
                SubmitedTime = now,
                Score = 0,
                ExamId = dto.ExamId
            };

            _context.ExamssScoreds.Add(examScored);
            await _context.SaveChangesAsync();

            foreach(var submitted in dto.Answers)
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
	}
}
