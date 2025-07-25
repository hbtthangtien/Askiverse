﻿using Application.DTOs.BasicUser;
using Application.DTOs.ForgotPassword;
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
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
namespace Application.Services
{
	public class AuthenticateService : Service, IAuthenticateService
	{
		private readonly IBasicUserService _basicUserService;
        private static readonly Dictionary<string, string> _otpStore = new();
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
                {
                    //await _basicUserService.SendEmailConfirmAsync(account!);
					throw new Exception("Bạn chưa xác nhận tài khoản!");
				}
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
            var fullName = principal.Claims.FirstOrDefault(c =>
    c.Type == ClaimTypes.Name || c.Type == "name")?.Value ?? username;

            var profile = new Domain.Entities.Profile
			{
				UserId = newUser.Id,
                Fullname = fullName,
                DateOfBirth = null,
                Bio = null,
                AvatarUrl = "https://as2.ftcdn.net/v2/jpg/03/31/69/91/1000_F_331699188_lRpvqxO5QRtwOM05gR50ImaaJgBx68vi.jpg"
            };
			profile.Gender = Domain.Enums.Gender.Other;

            var premiumUser = new PremiumUser
            {
                UserId = newUser.Id,
                IsActive = false
            };

			await _unitOfWork.Profiles.AddAsync(profile);
            await _unitOfWork.PremiumUsers.AddAsync(premiumUser);
            await _unitOfWork.CommitAsync();
            await _unitOfWork.BasicUsers.SignInManager.SignInAsync(newUser, isPersistent: false);
        }
        public async Task ForgotPasswordAsync(ForgotPasswordRequestDTO request)
        {
            var user = await _unitOfWork.BasicUsers.UserManager.FindByEmailAsync(request.Email);
            if (user == null)
                throw new Exception("Email không tồn tại!");

            var otp = new Random().Next(100000, 999999).ToString();
            _otpStore[user.Email] = otp;

            await SendEmailAsync(user.Email, "Mã OTP khôi phục mật khẩu", $"Mã OTP của bạn là: {otp}");
        }

        private async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("hungndhe172631@fpt.edu.vn\r\n", "axgs bslj mgex dwuc"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("hungndhe172631@fpt.edu.vn\r\n"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(toEmail);

            await smtpClient.SendMailAsync(mailMessage);
        }


        public async Task ResetPasswordWithOTPAsync(VerifyOTPAndResetPasswordDTO request)
        {
            if (!_otpStore.ContainsKey(request.Email) || _otpStore[request.Email] != request.OTP)
                throw new Exception("OTP không đúng hoặc đã hết hạn!");

            var passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");
            if (!passwordRegex.IsMatch(request.NewPassword))
                throw new Exception("Mật khẩu phải có ít nhất 8 ký tự, bao gồm 1 chữ hoa, 1 chữ thường, 1 số và 1 ký tự đặc biệt.");

            var user = await _unitOfWork.BasicUsers.UserManager.FindByEmailAsync(request.Email);
            if (user == null)
                throw new Exception("Người dùng không tồn tại!");

            var token = await _unitOfWork.BasicUsers.UserManager.GeneratePasswordResetTokenAsync(user);
            var result = await _unitOfWork.BasicUsers.UserManager.ResetPasswordAsync(user, token, request.NewPassword);

            if (!result.Succeeded)
                throw new Exception("Đặt lại mật khẩu thất bại!");

            _otpStore.Remove(request.Email);
        }


    }
}
