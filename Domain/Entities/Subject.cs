using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Exam> Exams { get; set; } = new List<Exam>();
    }
}
