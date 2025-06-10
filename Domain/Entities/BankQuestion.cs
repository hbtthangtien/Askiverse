using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BankQuestion :BaseEntity
    {
        public int QuestionTypeId { get; set; }

        public int LevelId { get; set; }

        public bool IsPublic { get; set; }

        public DateTime CreatedAt { get; set; }

        public string? PremiumUserId { get; set; }

        public string? Content { get; set; }

        public virtual Level? Level { get; set; }

        public virtual QuestionType? QuestionType { get; set; }

        public virtual PremiumUser? PremiumUser { get; set; }

        public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>()!;

        public virtual ICollection<QuestionExam> QuestionExams { get; set; } = new List<QuestionExam>()!;
    }
}
