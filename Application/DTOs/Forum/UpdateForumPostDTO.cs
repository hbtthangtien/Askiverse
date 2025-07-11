using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Application.DTOs.Forum
{
    public class UpdateForumPostDTO
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string HeadLine { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int SubjectId { get; set; }
        public string? ImgUrl { get; set; }

        [Required]
        public ForumStatus ForumStatus { get; set; }
    }
}
