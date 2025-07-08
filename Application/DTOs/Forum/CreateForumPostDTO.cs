using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Forum
{
    public class CreateForumPostDTO
    {
        public string Title { get; set; }
        public string HeadLine { get; set; }
        public string Content { get; set; }
        public string ImgUrl { get; set; }
        public int SubjectId { get; set; }
    }

}
