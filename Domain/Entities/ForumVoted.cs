using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ForumVoted
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public string VotedById { get; set; }

        public VoteType VotedType { get; set; }

        public DateTime VotedAt { get; set; }

        public virtual ForumPost? Post { get; set; }

        public virtual BasicUser? VotedBy { get; set; }


    }
}
