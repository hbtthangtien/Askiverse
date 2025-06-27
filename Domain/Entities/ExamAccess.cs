using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ExamAccess : BaseEntity
    {
        public int ExamId { get; set; }

        public DateTime AccessDate { get; set; }

        public string userId { get; set; }
        public bool Permission { get; set; }


        public virtual BasicUser? BasicUser { get; set; }

        public virtual Exam Exams { get; set; }

    }
}
