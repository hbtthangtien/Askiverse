using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ForumComment : BaseEntity
    {

        public int PostId { get; set; }

        public string UserId { get; set; }
        public string? Content { get; set; }

        public DateTime CommentedAt { get; set; }

        public int CommentById { get; set; }

        public DateTime UpdatedAt { get; set; }

        public virtual ForumPost? Post { get; set; }

        public virtual BasicUser? User { get; set; }


    }
}
