using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserAccessExam : BaseEntity
    {
        public int ExamId { get; set; }

        public string UserId { get; set; }

        public virtual Exam? Exams { get; set; }

        public virtual BasicUser? BasicUser { get; set; }
    }
}
