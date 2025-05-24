using Application.DTOs.BasicUser;
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
		public Task CreateBasicUserAsync(CreateBasicUserDTO dto);
		public Task ConfirmEmail(string UserId, string token);
		public Task SendEmailConfirmAsync(BasicUser basicUser);
	}
}
