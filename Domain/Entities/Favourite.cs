using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Favourite
    {
        public string UserId { get; set; } = null!;
        public int ExamId { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;

        public virtual BasicUser User { get; set; } = null!;
        public virtual Exam Exam { get; set; } = null!;
    }
}
