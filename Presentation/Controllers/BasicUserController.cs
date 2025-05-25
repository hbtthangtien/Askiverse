using Application.DTOs.BasicUser;
using Application.Interface.IServices;
using Microsoft.AspNetCore.Authentication;
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
        public async Task<IActionResult> Register(CreateBasicUserDTO dto)
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
                await _basicUserService.CreateBasicUserAsync(dto);
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
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            //await HttpContext.SignOutAsync();
            await _authenticateService.Logout();
            return RedirectToAction("Login");
        }
    }
}
