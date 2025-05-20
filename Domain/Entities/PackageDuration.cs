using Domain.Entities.Commons;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PackageDuration : BaseEntity
    {

        public string? Name { get; set; }

        public Duration? Duration { get; set; }

        public virtual ICollection<PackageOfUser> Users { get; set; } = new List<PackageOfUser>();
    }
}
    