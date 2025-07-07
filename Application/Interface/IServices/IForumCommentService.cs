using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Paginated;
using Domain.Entities;

namespace Application.Interface.IServices
{
    public interface IForumCommentService
    {
        Task<PaginatedList<ForumComment>> GetPagedCommentsAsync(int postId, int page, int pageSize);
    }
}
