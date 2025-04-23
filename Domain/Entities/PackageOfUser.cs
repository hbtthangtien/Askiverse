using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PackageOfUser
    {
        public int Id { get; set; }

        public int DurationId { get; set; }

        public int SubscriptionId { get; set; }

        public string UserId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool IsActived => DateTime.Now <= EndTime;

        public virtual PackageDuration? PackageDuration { get; set; }

        public virtual SubcriptionPackages? SubcriptionPackages { get; set; }

        public virtual PremiumUser? PremiumUser {  get; set; }  
    }
}
