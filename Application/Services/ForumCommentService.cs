using Application.Interface.IServices;
using Application.Paginated;
using Application.UnitOfWork;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ForumCommentService : Service, IForumCommentService
    {
        public ForumCommentService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<PaginatedList<ForumComment>> GetPagedCommentsAsync(int postId, int page, int pageSize)
        {
            return await _unitOfWork.ForumComments.GetPagedCommentsByPostIdAsync(postId, page, pageSize);
        }
    }
}
