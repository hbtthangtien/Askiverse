using Application.DTOs.Answer;
using Application.DTOs.Exam;
using Application.DTOs.ExamAnswered;
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
				ExamScoredId = examScoredId,
				Questions = exam.QuestionExam.Select(q => new Application.DTOs.Question.QuestionViewDetailsDTO
				{
					Id = q.Id,
					Content = q.Content,
					Answers = q.BankQuestion?.Answers
					.Select(a => new Application.DTOs.Answer.AnswerDTO
					{
						Id = a.Id,
						AnswerText = a.AnswerText ?? "",
						IsCorrected = a.IsCorrected,
						MatchingPairKey = a.MatchingPairKey,
					}).ToList() ?? new(),
					QuestionTypeId = q.QuestionTypeId,
				}).ToList(),
				UserAnswered = exam.ExamScoreds!
						.Where(es => es.Id == examScoredId)
						.SelectMany(es => es.ExamAnswereds)
						.GroupBy(ea => ea.QuestionExamId)
						.Select(group =>
						{
							var first = group.First();
							var questionTypeId = first.QuestionExam?.QuestionTypeId ?? 0;

							return questionTypeId switch
							{
								3 => new ExamAnsweredDTO
								{
									QuestionId = first.QuestionExamId,
									MatchingPairs = group
										.Where(g => g.MatchingBlankKey != null && g.AnswerId != null)
										.OrderBy(g => g.MatchingBlankKey)
										.Select(g => new MatchingPairDTO
										{
											MatchingBlankKey = g.MatchingBlankKey!,
											AnswerId = g.AnswerId!.Value
										}).ToList()
								},

								2 => new ExamAnsweredDTO
								{
									QuestionId = first.QuestionExamId,
									TextAnswer = first.UserInput
								},

								_ => new ExamAnsweredDTO
								{
									QuestionId = first.QuestionExamId,
									AnswerId = first.AnswerId
								}
							};
						}).ToList()
			};
		}
	}
}