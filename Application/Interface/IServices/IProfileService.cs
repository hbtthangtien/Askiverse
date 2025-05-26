using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Profile;

namespace Application.Interface.IServices
{
    public interface IProfileService
    {
        Task<ProfileDTO?> GetProfileByUserIdAsync(string userId);
        Task UpdateProfileAsync(string userId, UpdateProfileDTO dto);
        Task ChangePasswordAsync(string userId, ChangePasswordDTO dto);
    }


}
