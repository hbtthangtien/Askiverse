using Application.DTOs.BasicUser;
using Application.Interface.IServices;
using Application.UnitOfWork;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
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
	}
}
