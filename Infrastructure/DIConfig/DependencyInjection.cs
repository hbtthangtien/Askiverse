using Application.Automapper;
using Application.Interface.IRepository;
using Application.Interface.IServices;
using Application.Services;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DIConfig
{
    public static class DependencyInjection
    {
        public static void AddApplicationAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ApplicationMapper));
        }

        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAnswerService,AnsweredService>();
            services.AddScoped<IAuthenticateService,AuthenticateService>();
            services.AddScoped<IBankQuestionService,BankQuestionService>();
            services.AddScoped<IBasicUserService,BasicUserService>();
            services.AddScoped<IExamAccessService, ExamAccessService>();
            services.AddScoped<IExamAnsweredService, ExamAnsweredService>();
            services.AddScoped<IExamScoredService, ExamScoredService>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IForumCommentService, ForumCommentService>();
            services.AddScoped<IForumPostService, ForumPostService>();
            services.AddScoped<IForumVotedService,ForumVotedService>();
            services.AddScoped<IHistoryPurchaseService, HistoryPurchaseService>();
            services.AddScoped<ILevelService, LevelService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IPackageDurationService, PackageDurationService>();
            services.AddScoped<IPackageOfUserService, PackageOfUserService>();
            services.AddScoped<IPremiumUserService,PremiumUserService>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IQuestionExamService, QuestionExamService>();
            services.AddScoped<IQuestionTypeService, QuestionTypeService>();
            services.AddScoped<ISubjectService, SubjectService>();
            services.AddScoped<ISubscriptionPackagesService, SubscriptionPackageService>();
            services.AddScoped<IUserAccessExamService, UserAccessExamService>();
        }
    }
}
