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
    public class ForumVotedRepository : Repository<ForumVoted>, IForumVotedRepository
    {
        public ForumVotedRepository(AskiverseContext context) : base(context)
        {
        }
        public async Task<ForumVoted?> GetByUserAndPostAsync(string userId, int postId)
        {
            return await _context.ForumVoteds
                .FirstOrDefaultAsync(v => v.PostId == postId && v.VotedById == userId);
        }
    }
}
