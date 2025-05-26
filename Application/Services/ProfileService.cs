using Application.DTOs.Profile;
using Application.Interface.IServices;
using Application.UnitOfWork;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProfileService : Service, IProfileService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProfileService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _unitOfWork = unitOfWork;
        
        }
        public async Task<ProfileDTO?> GetProfileByUserIdAsync(string userId)
        {
            var profile = await _unitOfWork.Profiles.GetByUserIdAsync(userId);
            if (profile == null) return null;

            return new ProfileDTO
            {
                Fullname = profile.Fullname,
                AvatarUrl = profile.AvatarUrl,
                Gender = profile.Gender,
                DateOfBirth = profile.DateOfBirth,
                Bio = profile.Bio
            };
        }
        public async Task UpdateProfileAsync(string userId, UpdateProfileDTO dto)
        {
            var profile = await _unitOfWork.Profiles.GetByUserIdAsync(userId);
            if (profile == null)
                throw new Exception("Không tìm thấy hồ sơ.");

            profile.Fullname = dto.Fullname;
            profile.AvatarUrl = dto.AvatarUrl;
            profile.Gender = dto.Gender;
            profile.DateOfBirth = dto.DateOfBirth;
            profile.Bio = dto.Bio;

            _unitOfWork.Profiles.Update(profile);
            await _unitOfWork.CommitAsync();
        }
        public async Task ChangePasswordAsync(string userId, ChangePasswordDTO dto)
        {
            if (dto.NewPassword != dto.ConfirmPassword)
                throw new Exception("Xác nhận mật khẩu không khớp.");

            // Kiểm tra điều kiện mạnh của mật khẩu
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");
            if (!regex.IsMatch(dto.NewPassword))
                throw new Exception("Mật khẩu phải có ít nhất 1 chữ hoa, 1 chữ thường, 1 số và 1 ký tự đặc biệt.");

            var user = await _unitOfWork.BasicUsers.UserManager.FindByIdAsync(userId)
                       ?? throw new Exception("Không tìm thấy người dùng.");

            var result = await _unitOfWork.BasicUsers.UserManager.ChangePasswordAsync(user, dto.OldPassword, dto.NewPassword);

            if (!result.Succeeded)
                throw new Exception("Mật khẩu cũ không đúng hoặc mật khẩu mới không hợp lệ.");

            await _unitOfWork.CommitAsync();
        }
    }

}
