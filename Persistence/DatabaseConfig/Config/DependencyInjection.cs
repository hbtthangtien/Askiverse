using Application.Interface.IRepository;
using Application.UnitOfWork;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;
using Persistence.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DatabaseConfig.Config
{
    public static class DependencyInjection
    {
        public static void AddDatabaseDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AskiverseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAnswerRepository,AnswerRepository>();
            services.AddScoped<IBankQuestionRepository,BankQuestionRepository>();
            services.AddScoped<IBasicUserRepository,BasicUserRepository>();
            services.AddScoped<IExamAccessRepository,ExamAccessRepository>();
            services.AddScoped<IExamAnsweredRepository,ExamAnsweredRepository>();
            services.AddScoped<IExamRepository,ExamRepository>();
            services.AddScoped<IExamScoredRepository,ExamScoredRepository>();
            services.AddScoped<IForumCommentRepository,ForumCommentRepository>();
            services.AddScoped<IForumPostRepository,ForumPostRepository>(); 
            services.AddScoped<IForumVotedRepository,ForumVotedRepository>();
            services.AddScoped<IHistoryPurchaseRepository,HistoryPurchaseRepository>();
            services.AddScoped<ILevelRepository,LevelRepository>();
            services.AddScoped<INotificationRepository,NotificationRepository>();
            services.AddScoped<IPackageOfUserRepository, PackageOfUserRepository>();
            services.AddScoped<IPremiumUserRepository,PremiumUserRepository>();
            services.AddScoped<IProfileRepository,ProfileRepository>();
            services.AddScoped<IQuestionExamRepository,QuestionExamRepository>();
            services.AddScoped<IQuestionTypeRepository,QuestionTypeRepository>();
            services.AddScoped<ISubcriptionPackageRepository,SubscriptionPackagesRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<IUserAccessExamRepository, UserAccessExamRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
        }
        public static void AddIdentityConfig(this IServiceCollection services)
        {
            services.AddIdentity<BasicUser, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 8;

            })
                .AddEntityFrameworkStores<AskiverseContext>()
                .AddDefaultTokenProviders();
        }
    }
}
