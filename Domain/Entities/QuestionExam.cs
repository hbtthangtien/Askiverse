using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class QuestionExam : BaseEntity
    {
        public int ExamId { get; set; }

        public int BankQuestionId { get; set; }

        public int QuestionTypeId { get; set; }

        public int LevelId { get; set; }

        public bool IsPublic { get; set; }

        public DateTime CreatedAt { get; set; }

        public string? Content { get; set; }

        public virtual Exam? Exam { get; set; }
        public virtual BankQuestion? BankQuestion { get; set; }
        public virtual ICollection<ExamAnswered> ExamAnswereds { get; set; } = new List<ExamAnswered>();
    }
}
