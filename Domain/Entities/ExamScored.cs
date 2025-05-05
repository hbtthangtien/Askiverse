using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ExamScored
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime SubmitedTime { get; set; }

        public double Score { get; set; }

        public virtual BasicUser? User { get; set; }

        public virtual Exams? Exam { get; set; }

        public virtual ICollection<ExamAnswered> ExamAnswereds { get; set; } = new List<ExamAnswered>();
    }
}
