using Application.DTOs.BasicUser;
using Application.DTOs.ForgotPassword;
using Application.Interface.IServices;
using Domain.Enums;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class BasicUserController : Controller
    {
        private readonly IBasicUserService _basicUserService;
        private readonly IAuthenticateService _authenticateService;

        public BasicUserController(IBasicUserService basicUserService, IAuthenticateService authenticateService)
        {
            _basicUserService = basicUserService;
            _authenticateService = authenticateService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new CreateBasicUserDTO());
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginDTORequest());
        }

        [HttpPost]
        public async Task<IActionResult> Register(CreateBasicUserDTO dto, string gender)
        {
            if (!ModelState.IsValid)
            {
                var firstError = ModelState
                    .Where(x => x.Value!.Errors.Count > 0)
                    .Select(x => x.Value!.Errors.First().ErrorMessage)
                    .FirstOrDefault();
                ViewData["ErrorMessage"] = firstError;
                return View(dto);
            }

            try
            {
                await _basicUserService.CreateBasicUserAsync(dto, gender);
                return View("ConfirmationNotification");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View(dto);
            }
        }

        public async Task<IActionResult> Login(LoginDTORequest dto)
        {
            try
            {
                await _authenticateService.AuthenticateCretial(dto);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View(dto);
            }
        }

        [HttpGet("basic-user/confirm-email")]
        public async Task<IActionResult> ConfirmEmail(string UserId, string token)
        {
            try
            {
                await _basicUserService.ConfirmEmail(UserId, token);
                return View();
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
                return View();
            }
        }

        [HttpGet]
        public async Task StartGoogleLogin()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme,
                new AuthenticationProperties
                {
                    RedirectUri = Url.Action("HandleGoogleLoginCallback")
                });
        }

        public async Task<IActionResult> HandleGoogleLoginCallback()
        {
            try
            {
                var result = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);
                if (!result.Succeeded)
                {
                    return RedirectToAction("Login");
                }

                var principal = result.Principal;
                await _authenticateService.ProcessGoogleUserAsync(principal);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View("Login");
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            await _authenticateService.Logout();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult EmailForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequestDTO dto)
        {
            try
            {
                await _authenticateService.ForgotPasswordAsync(dto); // ✅ controller không xử lý chi tiết
                TempData["Email"] = dto.Email; // để truyền sang view ResetPassword
                return RedirectToAction("ResetPassword");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(dto); // trả lại view quên mật khẩu
            }
        }

        [HttpGet]
        public IActionResult ResetPassword()
        {
            var email = TempData["Email"]?.ToString();
            return View(new VerifyOTPAndResetPasswordDTO { Email = email });
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(VerifyOTPAndResetPasswordDTO dto)
        {
            try
            {
                await _authenticateService.ResetPasswordWithOTPAsync(dto); // ✅ logic trong service
                ViewBag.Message = "Mật khẩu đã được đặt lại thành công.";
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(dto); // trả lại view nhập lại OTP và mật khẩu
            }
        }

        [HttpPost]
        public async Task<IActionResult> EmailForgotPassword(string email)
        {
            try
            {
                await _basicUserService.SendEmailResetPasswordAsync(email);
                return View("ResetPasswordNotification");

            }
            catch(Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View();
            }
        }

        [HttpGet("basic-user/reset-password")]
         public IActionResult ResetPassword(string userId, string token)
        {
            try
            {
                return View(new ResetPasswordDTORequest { UserId = userId, Token = token});
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
                return View();
            }
        }

        [HttpPost("basic-user/reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordDTORequest dto)
        {
            if (!ModelState.IsValid)
            {
                var firstError = ModelState
                    .Where(x => x.Value!.Errors.Count > 0)
                    .Select(x => x.Value!.Errors.First().ErrorMessage)
                    .FirstOrDefault();
                ViewData["ErrorMessage"] = firstError;
                return View(dto);
            }

            try
            {
                await _basicUserService.ResetPassword(dto);
                return View("ResetSuccessfulNotification");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View(dto);
            }
        }

    }
}
