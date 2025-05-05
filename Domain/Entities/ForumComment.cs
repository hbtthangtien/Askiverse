using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ForumComment
    {
        public int Id { get; set; } 

        public int PostId { get; set; }

        public string? Content { get; set; }

        public DateTime CommentedAt { get; set; }

        public required string CommentById { get; set; }

        public DateTime UpdatedAt { get; set; }

        public virtual ForumPost? Post { get; set; }

        public virtual BasicUser? User { get; set; }


    }
}
