using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserAccessExam
    {
        public int Id { get; set; } 

        public int ExamId { get; set; }

        public string UserId { get; set; }

        public virtual Exams? Exams { get; set; }

        public virtual BasicUser? BasicUser { get; set; }
    }
}
