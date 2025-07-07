using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IRepository
{
    public interface IForumVotedRepository : IRepository<ForumVoted>
    {
        Task<ForumVoted?> GetByUserAndPostAsync(string userId, int postId);
    }
}
