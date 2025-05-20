using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Commons
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime DeletedAt { get; set; }

        public string? UpdateBy { get; set; }
    }
}
