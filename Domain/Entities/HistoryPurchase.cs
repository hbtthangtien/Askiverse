using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HistoryPurchase
    {
        public int Id { get; set; }

        public string? UserId { get; set; }

        public string? SubcriptionName { get; set; }

        public Duration? Duration { get; set; } 

        public virtual PremiumUser? PremiumUser { get; set; }
    }
}
