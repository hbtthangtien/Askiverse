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
    public class ForumPostRepository : Repository<ForumPost>, IForumPostRepository
    {
        public ForumPostRepository(AskiverseContext context) : base(context)
        {
        }
    }
}
