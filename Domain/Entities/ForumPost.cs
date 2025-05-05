using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ForumPost
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string HeadLine { get; set; }

        public string Content { get; set; }

        public string ImgUrl { get; set; }

        public string CreatedById { get; set; }

        public DateTime CreatedAt { get; set; }

        public int SubjectId { get; set; }

        public int QuestionId { get; set; }

        public bool IsPinned { get; set; }

        public ForumStatus ForumStatus { get; set; }

        public DateTime UpdatedAt { get; set; }

        public virtual QuestionExam? QuestionExam { get; set; }

        public virtual Subject? Subject { get; set; }

        public virtual BasicUser? CreatedBy { get; set; }

        public virtual ICollection<ForumComment> Comments { get; set; } = new List<ForumComment>();

        public virtual ICollection<ForumVoted> Voteds { get; set; } = new List<ForumVoted>();
        

    }
}
