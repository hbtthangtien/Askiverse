using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SubcriptionPackages : BaseEntity
    {

        public string? Name { get; set; }    

        public string? Description { get; set; }
    }
}
