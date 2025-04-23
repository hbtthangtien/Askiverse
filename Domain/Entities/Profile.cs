using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Profile
    {
        [Required]
        public string UserId { get; set; }

        public string? Fullname { get; set; }

        public string? AvatarUrl { get; set; }

        public Gender Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? Bio {  get; set; }

        public virtual BasicUser? User { get; set; }
    }
}
