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
    public class BankQuestionRepository : Repository<BankQuestion>, IBankQuestionRepository
    {
        public BankQuestionRepository(AskiverseContext context) : base(context)
        {
        }
        public IQueryable<BankQuestion> Query()
        {
            return _context.Set<BankQuestion>().AsQueryable();
        }
       
        public async Task<BankQuestion?> GetByIdWithAnswersAsync(int id)
        {
            return await _context.BankQuestions
                .Include(q => q.Level)
                .Include(q => q.QuestionType)
                .Include(q => q.Answers)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
        public async Task<List<int>> GetRandomQuestionIdsAsync(int count, SearchBankQuestionFilter filter)
        {
            var query = _context.BankQuestions.AsQueryable();

            if (filter.QuestionTypeId.HasValue)
                query = query.Where(q => q.QuestionTypeId == filter.QuestionTypeId);

            if (filter.LevelId.HasValue)
                query = query.Where(q => q.LevelId == filter.LevelId);

            if (filter.IsPublic.HasValue)
                query = query.Where(q => q.IsPublic == filter.IsPublic);

            if (!string.IsNullOrEmpty(filter.Keyword))
                query = query.Where(q => q.Content.Contains(filter.Keyword));

            return await query
                .OrderBy(x => Guid.NewGuid()) // Random
                .Take(count)
                .Select(q => q.Id)
                .ToListAsync();
        }

    }
}
