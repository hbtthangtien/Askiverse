using Application.Interface.IRepository;
using Domain.Entities;
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

    }
}
