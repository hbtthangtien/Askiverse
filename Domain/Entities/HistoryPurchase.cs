using Domain.Entities.Commons;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HistoryPurchase : BaseEntity
    {
        public string? UserId { get; set; }

        public string? SubcriptionName { get; set; }

        public Duration? Duration { get; set; } 

        public virtual BasicUser? BasicUser { get; set; }
    }
}
