using Application.DTOs.BasicUser;
using Application.DTOs.ForgotPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IServices
{
    public interface IAuthenticateService
    {
        public Task AuthenticateCretial(LoginDTORequest request);
        public Task Logout();
        public Task ProcessGoogleUserAsync(ClaimsPrincipal principal);
        Task ForgotPasswordAsync(ForgotPasswordRequestDTO request);
        Task ResetPasswordWithOTPAsync(VerifyOTPAndResetPasswordDTO request);

    }
}
