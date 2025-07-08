using Application.DTOs.Exam;
using Application.Paginated;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IRepository
{
    public interface IBankQuestionRepository : IRepository<BankQuestion>
    {
        IQueryable<BankQuestion> Query();
        Task<BankQuestion?> GetByIdWithAnswersAsync(int id);
        Task<List<int>> GetRandomQuestionIdsAsync(int count, SearchBankQuestionFilter filter, string? PremiumUserId);

        Task AddRange(List<BankQuestion> list);
       
    }
}
