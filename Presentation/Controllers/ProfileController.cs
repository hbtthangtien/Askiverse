using Application.Interface.IServices;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.Profile;

namespace Presentation.Controllers
{
    [Authorize]
    [Route("profile")]
    public class ProfileController : Controller
    {
        private readonly IProfileService _profileService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProfileController(IProfileService profileService, IHttpContextAccessor httpContextAccessor)
        {
            _profileService = profileService;
            _httpContextAccessor = httpContextAccessor;
        }

        private string GetCurrentUserId()
        {
            return _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)!;
        }

        [HttpGet("view")]
        public async Task<IActionResult> ViewProfile()
        {
            var userId = GetCurrentUserId();
            var profile = await _profileService.GetProfileByUserIdAsync(userId);

            if (profile == null)
                return NotFound("Không tìm thấy thông tin hồ sơ.");

            return View("Profile", profile); // view name: Profile.cshtml
        }
        [HttpGet("edit")]
        public async Task<IActionResult> Edit()
        {
            var userId = GetCurrentUserId();
            var profile = await _profileService.GetProfileByUserIdAsync(userId);
            if (profile == null) return NotFound("Không tìm thấy hồ sơ.");

            var model = new UpdateProfileDTO
            {
                Fullname = profile.Fullname,
                AvatarUrl = profile.AvatarUrl,
                Gender = profile.Gender,
                DateOfBirth = profile.DateOfBirth,
                Bio = profile.Bio
            };

            return View("EditProfile", model);
        }

        [HttpPost("edit")]
        public async Task<IActionResult> Edit(UpdateProfileDTO model)
        {
            if (!ModelState.IsValid)
                return View("EditProfile", model);

            var userId = GetCurrentUserId();
            await _profileService.UpdateProfileAsync(userId, model);

            return RedirectToAction("ViewProfile");
        }
        [HttpGet("change-password")]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword(ChangePasswordDTO dto)
        {
            try
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value!;
                await _profileService.ChangePasswordAsync(userId, dto);
                TempData["Success"] = "Đổi mật khẩu thành công.";
                return RedirectToAction("ViewProfile");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(dto);
            }
        }

    }

}
