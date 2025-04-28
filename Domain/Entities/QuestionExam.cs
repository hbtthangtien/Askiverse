using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class QuestionExam
    {
        public int Id { get; set; }

        public int ExamId { get; set; }

        public int BankQuestionId { get; set; }

        public int QuestionTypeId { get; set; }

        public int LevelId { get; set; }

        public bool IsPublic { get; set; }

        public DateTime CreatedAt { get; set; }

        public string? Content { get; set; }

        public virtual Exams? Exam { get; set; }
    }
}
