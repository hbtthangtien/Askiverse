using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ExamAccess
    {
        public int Id { get; set; }

        public int ExamId { get; set; }

        public DateTime AccessDate { get; set; }

        public string userId { get; set; }

        public virtual BasicUser? BasicUser { get; set; }

        public virtual Exams Exams { get; set; }

    }
}
