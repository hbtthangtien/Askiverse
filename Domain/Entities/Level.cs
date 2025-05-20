using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Level : BaseEntity
    {

        public string DisplayName { get; set; }

        public virtual ICollection<BankQuestion> Levels { get; set; } = new List<BankQuestion>();
    }
}
