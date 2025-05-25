using Application.DTOs.BasicUser;
using Application.Interface.IExternalService;
using Application.Interface.IServices;
using Application.UnitOfWork;
using AutoMapper;
using Domain.Constants;
using Domain.Entities;
using Domain.Enums;
using System.Security.Principal;

namespace Application.Services
{
	public class BasicUserService : Service, IBasicUserService
    {
        private readonly IEmailService _email;
        public BasicUserService(IUnitOfWork unitOfWork, IMapper mapper, IEmailService email) : base(unitOfWork, mapper)
        {
            _email = email;
        }

        public async Task ConfirmEmail(string UserId, string token)
        {
			var User = await _unitOfWork.BasicUsers.UserManager.FindByIdAsync(UserId)
				?? throw new Exception("Người dùng không tồn tại!");
			var confirmEmail = await _unitOfWork.BasicUsers.UserManager.ConfirmEmailAsync(User, token);
			if (!confirmEmail.Succeeded)
			{
				throw new Exception("Token không hợp lệ!");
			}
		}

		public async Task CreateBasicUserAsync(CreateBasicUserDTO dto)
		{
			var entityUser = new BasicUser
			{
				UserName = dto.Username,
				Email = dto.Email,
				CreatedAt = DateTime.Now,
				AccountStatus = AccountStatus.Active
			};

			var create = await _unitOfWork.BasicUsers.UserManager.CreateAsync(entityUser, dto.Password);

			if(!create.Succeeded)
			{
				var error = create.Errors.First().Code;

				if (error == "DuplicateUserName")
					throw new Exception("Tên đăng nhập đã tồn tại!");

				if (error == "DuplicateEmail")
					throw new Exception("Email đã tồn tại!");
			}

			await _unitOfWork.BasicUsers.UserManager.AddToRoleAsync(entityUser, UserRole.BASIC_USER);

			await _unitOfWork.CommitAsync();
			await SendEmailConfirmAsync(entityUser);
		}

		public async Task SendEmailConfirmAsync(BasicUser basicUser)
		{
			string token = await _unitOfWork.BasicUsers.UserManager.GenerateEmailConfirmationTokenAsync(basicUser);
			UriBuilder uriBuilder = LinkConstant.UriBuilder(basicUser.Id, token, "confirm-email");
			var link = uriBuilder.ToString();
			var body = EmailBody.CONFIRM_EMAIL(basicUser.Email!, link);
			await _email.SendMailAsync(EmailSubject.CONFIRM_EMAIL, body, basicUser.Email!);
		}
	}
}
