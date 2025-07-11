using Application.Paginated;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IRepository
{
    public interface IForumCommentRepository : IRepository<ForumComment>
    {
        Task<PaginatedList<ForumComment>> GetPagedCommentsByPostIdAsync(int postId, int pageIndex, int pageSize);
        Task<ForumComment?> GetByIdAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
