using Application.DTOs.BasicUser;
using Application.Interface.IServices;
using Application.UnitOfWork;
using AutoMapper;
using Domain.Constants;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
	public class AuthenticateService : Service, IAuthenticateService
	{
		private readonly IBasicUserService _basicUserService;
		public AuthenticateService(IUnitOfWork unitOfWork, IBasicUserService basicUserService, IMapper mapper) : base(unitOfWork, mapper)
		{
			_basicUserService = basicUserService;
		}

		public async Task AuthenticateCretial(LoginDTORequest request)
		{
			var account = (request.UsernameOrEmail!.Contains('@'))
				? await _unitOfWork.BasicUsers.UserManager.FindByEmailAsync(request.UsernameOrEmail)
				: await _unitOfWork.BasicUsers.UserManager.FindByNameAsync(request.UsernameOrEmail)
				?? throw new Exception("Username hoặc Email không tồn tại!");
			var checkPasswork = await _unitOfWork.BasicUsers.SignInManager.CheckPasswordSignInAsync(account!, request.Password!, false);
			if (!checkPasswork.Succeeded)
			{
				throw new Exception("Mật khẩu không chính xác!");
			}
			else
			{
				var checkEmail = await _unitOfWork.BasicUsers.UserManager.IsEmailConfirmedAsync(account!);
				if (!checkEmail)
					throw new Exception("Bạn chưa xác nhận tài khoản!");
				else
					await _unitOfWork.BasicUsers.SignInManager
						.PasswordSignInAsync(account!, request.Password!, false, lockoutOnFailure: false);
			}
		}

		public async Task Logout()
		{
			await _unitOfWork.BasicUsers.SignInManager.SignOutAsync();
		}

		public async Task ProcessGoogleUserAsync(ClaimsPrincipal principal)
		{
            var email = principal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            if (string.IsNullOrEmpty(email))
                throw new Exception("Không lấy được email từ tài khoản Google!");

            var username = email.Split('@')[0];
            var existingUser = await _unitOfWork.BasicUsers.UserManager.FindByEmailAsync(email);

            if (existingUser != null)
			{
                await _unitOfWork.BasicUsers.SignInManager.SignInAsync(existingUser, isPersistent: false);
				return;
            }

            var password = Guid.NewGuid().ToString();
            var passwordHasher = new PasswordHasher<BasicUser>();
            var hashedPassword = passwordHasher.HashPassword(null, password);
            var newUser = new BasicUser { UserName = username, Email = email, CreatedAt = DateTime.Now, AccountStatus = Domain.Enums.AccountStatus.Active };
            var result = await _unitOfWork.BasicUsers.UserManager.CreateAsync(newUser, hashedPassword);

            if (!result.Succeeded)
                throw new Exception(result.Errors.FirstOrDefault()?.Description ?? "Tạo tài khoản thất bại!");

            await _unitOfWork.BasicUsers.UserManager.AddToRoleAsync(newUser, UserRole.BASIC_USER);

			var profile = new Domain.Entities.Profile
			{
				UserId = newUser.Id,
			};
			profile.Gender = Domain.Enums.Gender.Other;

			await _unitOfWork.Profiles.AddAsync(profile);
            await _unitOfWork.CommitAsync();
            await _unitOfWork.BasicUsers.SignInManager.SignInAsync(newUser, isPersistent: false);
        }

    }
}
