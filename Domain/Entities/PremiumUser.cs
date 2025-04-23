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

        public virtual ICollection<HistoryPurchase> HistoryPurchase { get; set; } = new List<HistoryPurchase>()!;

        public virtual ICollection<PackageOfUser> PackageOfUsers { get; set; } = new List<PackageOfUser>()!;

        public virtual PackageOfUser? CurrentPackage => PackageOfUsers.FirstOrDefault(e => e.IsActived);

    }
}
