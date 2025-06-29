using Application.DTOs.BasicUser;
using Application.DTOs.EmailResendConfirm;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IServices
{
    public interface IBasicUserService
    {
		public Task CreateBasicUserAsync(CreateBasicUserDTO dto, string gender);
		public Task ConfirmEmail(string UserId, string token);
		public Task SendEmailConfirmAsync(BasicUser basicUser);
        public Task SendEmailResetPasswordAsync(string email);
        public Task ResetPassword(ResetPasswordDTORequest dto);
		public Task ReSendEmailConfirmAsync(EmailResendConfirmDTO dto);
	}
}
