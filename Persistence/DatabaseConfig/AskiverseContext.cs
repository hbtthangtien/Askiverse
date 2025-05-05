using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DatabaseConfig
{
    public class AskiverseContext : IdentityDbContext<BasicUser>
    {
        public AskiverseContext(DbContextOptions<AskiverseContext> options) : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }

        public virtual DbSet<BankQuestion> BankQuestions { get; set; }

        public virtual DbSet<ExamAccess> ExamAccessess { get; set; }

        public virtual DbSet<ExamAnswered> ExamAnswereds { get; set;}

        public virtual DbSet<Exams> Examss {  get; set; }

        public virtual DbSet<ExamScored> ExamssScoreds { get;set; }

        public virtual DbSet<ForumComment> ForumComments { get; set; }

        public virtual DbSet<ForumPost> ForumPosts { get; set; }

        public virtual DbSet<ForumVoted> ForumVoteds { get; set; }

        public virtual DbSet<HistoryPurchase> HistoryPurchases { get; set; }

        public virtual DbSet<Level> Levels { get; set; }    

        public virtual DbSet<Notification> Notifications { get; set; }

        public virtual DbSet<PackageDuration> PackageDurations { get; set; }

        public virtual DbSet<PackageOfUser> PackageOfUsers { get; set; }

        public virtual DbSet<PremiumUser> PremiumUsers { get; set; }

        public virtual DbSet<Profile> Profiles { get; set; }

        public virtual DbSet<QuestionExam> QuestionExams { get; set; }

        public virtual DbSet<QuestionType> QuestionTypes { get; set; }

        public virtual DbSet<SubcriptionPackages> SubcriptionPackages { get; set;}

        public virtual DbSet<Subject> Subjects { get; set; }

        public virtual DbSet<UserAccessExam> UserAccessExams { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Answer>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityColumn();
                entity.HasOne(e => e.BankQuestion)
                    .WithMany(e => e.Answers)
                    .HasForeignKey(e => e.BankQuestionId);


            });

        }
    }
}
