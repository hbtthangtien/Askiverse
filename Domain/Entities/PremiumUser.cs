using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PremiumUser
    {
        public string UserId { get; set; }

        public virtual BasicUser? BasicUser { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<BankQuestion> BankQuestions { get; set; } = new List<BankQuestion>()!;
    }
}
