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
    public class QuestionTypeRepository : Repository<QuestionType>, IQuestionTypeRepository
    {
        public QuestionTypeRepository(AskiverseContext context) : base(context)
        {
        }
    }
}
