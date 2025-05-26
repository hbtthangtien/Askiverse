using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Application.DTOs.Profile
{
    public class ProfileDTO
    {
        public string? Fullname { get; set; }
        public string? AvatarUrl { get; set; }
        public Gender Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Bio { get; set; }
    }

}
