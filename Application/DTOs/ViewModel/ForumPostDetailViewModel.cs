using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Paginated;
using Domain.Entities;

namespace Application.DTOs.ViewModel
{
    public class ForumPostDetailViewModel
    {
        public ForumPost ForumPost { get; set; }
        public PaginatedList<ForumComment> PaginatedComments { get; set; }
    }

}
