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
    public class ExamScoredRepository : Repository<ExamScored>, IExamScoredRepository
    {
        public ExamScoredRepository(AskiverseContext context) : base(context)
        {
        }

        public async Task<List<ExamScored>> GetAllExamScoredByUserIdByExamId(string userId, int examId)
        {
            var examScored = await _context.ExamssScoreds
                .Where(es => es.UserId.Equals(userId) && es.ExamId == examId)
                .OrderByDescending(es => es.SubmitedTime)
                .ToListAsync();
            return examScored;
        }

        public async Task<ExamScored?> GetExamScoredById(int examScoredId)
        {
            var examScored = await _context.ExamssScoreds
                .Include(es => es.Exam)
                .FirstOrDefaultAsync(e => e.Id == examScoredId);
            return examScored;
        }

        public async Task<ExamViewDetailsDTO?> GetExamDetails(int examScoredId, int examId)
        {
            var exam = await _context.Examss
                    .Include(e => e.QuestionExam)
                        .ThenInclude(e => e.BankQuestion)
                        .ThenInclude(e => e.Answers)
                    .Include(e => e.ExamScoreds)
                        .ThenInclude(e => e.ExamAnswereds)
                    .FirstOrDefaultAsync(e => e.Id == examId);

            if (exam == null) return null;

            return new ExamViewDetailsDTO
            {
                Id = exam.Id,
                Questions = exam.QuestionExam.Select(q => new Application.DTOs.Question.QuestionViewDetailsDTO
                {
                    Id = q.Id,
                    Content = q.Content,
                    Answers = q.BankQuestion?.Answers.Select(a => new Application.DTOs.Answer.AnswerDTO
                    {
                        Id = a.Id,
                        AnswerText = a.AnswerText ?? "",
                        IsCorrected = a.IsCorrected
                    }).ToList() ?? new()
                }).ToList(),
                UserAnswered = exam.ExamScoreds?.Where(es => es.Id == examScoredId)
                                .SelectMany(es => es.ExamAnswereds)
                                .Select(ea => new Application.DTOs.ExamAnswered.ExamAnsweredDTO
                                {
                                    QuestionId = ea.QuestionExamId,
                                    AnswerId = ea.AnswerId
                                }).ToList() ?? new()
            };
        }
    }
}