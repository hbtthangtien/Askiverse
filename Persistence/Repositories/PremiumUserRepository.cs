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
    public class PremiumUserRepository : Repository<PremiumUser>, IPremiumUserRepository
    {
        public PremiumUserRepository(AskiverseContext context) : base(context)
        {
        }
    }
}
