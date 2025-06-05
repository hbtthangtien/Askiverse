using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PackageOfUser : BaseEntity
    {
        public int Id { get; set; }

        public int SubscriptionId { get; set; }

        public string UserId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool IsActived => DateTime.Now <= EndTime;

        public virtual SubcriptionPackages? SubcriptionPackages { get; set; }

        public virtual BasicUser? BasicUser {  get; set; }  
    }
}
