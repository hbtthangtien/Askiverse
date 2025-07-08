using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Application.DTOs.Forum
{
    public class ForumPostFilterDTO
    {
        public int? SubjectId { get; set; }
        public string? SortOrder { get; set; } = "newest";
        public string? Keyword { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 5;
        public string? CreatedById { get; set; }
        public ForumStatus? ForumStatus { get; set; }
    }

}
