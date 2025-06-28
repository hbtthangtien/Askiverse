using Domain.Constants;
using Domain.Entities;
using Domain.Entities.Commons;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistence.Extensions;
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

		public virtual DbSet<ExamAnswered> ExamAnswereds { get; set; }

		public virtual DbSet<Exam> Examss { get; set; }

		public virtual DbSet<ExamScored> ExamssScoreds { get; set; }

		public virtual DbSet<ForumComment> ForumComments { get; set; }

		public virtual DbSet<ForumPost> ForumPosts { get; set; }

		public virtual DbSet<ForumVoted> ForumVoteds { get; set; }

		public virtual DbSet<HistoryPurchase> HistoryPurchases { get; set; }

		public virtual DbSet<Level> Levels { get; set; }

		public virtual DbSet<Notification> Notifications { get; set; }

		public virtual DbSet<PackageOfUser> PackageOfUsers { get; set; }

		public virtual DbSet<PremiumUser> PremiumUsers { get; set; }

		public virtual DbSet<Profile> Profiles { get; set; }

		public virtual DbSet<QuestionExam> QuestionExams { get; set; }

		public virtual DbSet<QuestionType> QuestionTypes { get; set; }

		public virtual DbSet<SubcriptionPackages> SubcriptionPackages { get; set; }

		public virtual DbSet<Subject> Subjects { get; set; }

		public virtual DbSet<UserAccessExam> UserAccessExams { get; set; }

		public virtual DbSet<Favourite> Favourites { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<BasicUser>(entity =>
			{
				entity.ToTable("BasicUser");

				entity.HasMany(e => e.PackageOfUsers)
					  .WithOne(e => e.BasicUser)
					  .HasForeignKey(e => e.UserId)
					  .OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(e => e.Profile)
					  .WithOne(e => e.User)
					  .HasForeignKey<Profile>(e => e.UserId);

				entity.HasOne(e => e.PremiumUser)
					  .WithOne(e => e.BasicUser)
					  .HasForeignKey<PremiumUser>(e => e.UserId);

				entity.HasMany(e => e.ReceiveNotifications)
					  .WithOne(e => e.Receiver)
					  .HasForeignKey(e => e.ReceiverId)
					  .IsRequired();

				entity.HasMany(e => e.SentNotifications)
					  .WithOne(e => e.Sender)
					  .HasForeignKey(e => e.SenderId);

				entity.HasMany(e => e.HistoryPurchase)
					   .WithOne(e => e.BasicUser)
					   .HasForeignKey(e => e.UserId);

				entity.HasMany(e => e.ExamScored)
					  .WithOne(e => e.User)
					  .HasForeignKey(e => e.UserId);

				entity.HasMany(e => e.ForumPosts)
					  .WithOne(e => e.CreatedBy)
					  .HasForeignKey(e => e.CreatedById);

				entity.HasMany(e => e.ForumComments)
					  .WithOne(e => e.User)
					  .HasForeignKey(e => e.CommentById);

				entity.HasMany(e => e.ForumVoteds)
					  .WithOne(e => e.VotedBy)
					  .HasForeignKey(e => e.VotedById);
				
			});
			builder.Entity<PremiumUser>(entity =>
			{
				entity.HasKey(e => e.UserId);
				entity.HasOne(e => e.BasicUser)
					 .WithOne(e => e.PremiumUser)
					 .HasForeignKey<PremiumUser>(e => e.UserId);
				entity.HasMany(e => e.BankQuestions)
					  .WithOne(e => e.PremiumUser)
					  .HasForeignKey(e => e.PremiumUserId);
			});
			builder.Entity<Profile>(entity =>
			{
				entity.HasKey(e => e.UserId);
				entity.HasOne(e => e.User)
					 .WithOne(e => e.Profile)
					 .HasForeignKey<Profile>(e => e.UserId);
			});
			builder.Entity<IdentityRole>(entity =>
			{
				entity.ToTable("Roles");
			});
			builder.Entity<IdentityUserRole<string>>();
			builder.Entity<Answer>(entity =>
			{
				entity.Property(e => e.Id)
					.HasColumnName("id")
					.UseIdentityColumn();
				entity.HasOne(e => e.BankQuestion)
					.WithMany(e => e.Answers)
					.HasForeignKey(e => e.BankQuestionId);
			});
			builder.Entity<BankQuestion>(entity =>
			{
				entity.Property(e => e.Id)
					  .HasColumnName("id")
					  .UseIdentityColumn();
				entity.HasOne(e => e.PremiumUser)
					  .WithMany(e => e.BankQuestions)
					  .HasForeignKey(e => e.PremiumUserId);
				entity.HasMany(e => e.Answers)
					  .WithOne(e => e.BankQuestion)
					  .HasForeignKey(e => e.BankQuestionId);
			});
			builder.Entity<ExamAccess>(entity =>
			{
				entity.HasOne(e => e.BasicUser)
					  .WithMany(e => e.ExamAccesses)
					  .HasForeignKey(e => e.userId);

				entity.HasOne(e => e.Exams)
					   .WithMany(e => e.ExamAccesses)
					   .HasForeignKey(e => e.ExamId);
			});
			builder.Entity<Exam>(entity =>
			{
				entity.HasOne(e => e.Subject)
					  .WithMany(e => e.Exams)
					  .HasForeignKey(e => e.SubjectId);
			});
			builder.Entity<ExamAnswered>(entity =>
			{
				entity.HasOne(e => e.Answer)
					  .WithMany(e => e.ExamAnswereds)
					  .HasForeignKey(e => e.AnswerId)
					  .OnDelete(DeleteBehavior.NoAction);
				entity.HasOne(e => e.ExamScored)
					  .WithMany(e => e.ExamAnswereds)
					  .HasForeignKey(e => e.ExamScoredId);
				entity.HasOne(e => e.QuestionExam)
					.WithMany(e => e.ExamAnswereds)
					.HasForeignKey(e => e.QuestionExamId)
					.OnDelete(DeleteBehavior.NoAction);
			});
			builder.Entity<ExamScored>(entity =>
			{
				entity.HasOne(e => e.User)
					  .WithMany(e => e.ExamScored)
					  .HasForeignKey(e => e.UserId)
					  .OnDelete(DeleteBehavior.NoAction);
			});
			builder.Entity<ForumComment>(entity =>
			{
				entity.HasOne(e => e.Post)
					  .WithMany(e => e.Comments)
					  .HasForeignKey(e => e.CommentById)
					  .OnDelete(DeleteBehavior.NoAction);

				entity.HasOne(e => e.User)
					  .WithMany(e => e.ForumComments)
					  .HasForeignKey(e => e.UserId)
					  .OnDelete(DeleteBehavior.NoAction);
			});
			builder.Entity<ForumVoted>(entity =>
			{
				entity.HasOne(e => e.Post)
					  .WithMany(e => e.Voteds)
					  .HasForeignKey(e => e.PostId)
					  .OnDelete(DeleteBehavior.NoAction);
			});

			builder.Entity<Favourite>(entity =>
			{
				entity.HasKey(f => new { f.UserId, f.ExamId });

				entity.HasOne(f => f.User)
						.WithMany(u => u.Favourites)
						.HasForeignKey(f => f.UserId)
						.OnDelete(DeleteBehavior.NoAction);

				entity.HasOne(f => f.Exam)
						.WithMany(e => e.FavouritedByUsers)
						.HasForeignKey(f => f.ExamId)
						.OnDelete(DeleteBehavior.NoAction);
			});


			builder.Entity<IdentityRole>()
				.HasData(
					new IdentityRole { Id = "1", Name = UserRole.BASIC_USER, NormalizedName = UserRole.BASIC_USER },
					new IdentityRole { Id = "2", Name = UserRole.PREMIUM_USER, NormalizedName = UserRole.PREMIUM_USER },
					new IdentityRole { Id = "3", Name = UserRole.ADMIN, NormalizedName = UserRole.ADMIN }
				);


			//seeding data
			CategoryQuestionSeedingData.Seed(builder);
			//SeedingTrietExamData.Seeding(builder);
			SubjectSeedingData.Seeding(builder);
			SubscriptionSeedingData.Seeding(builder);

		}
        public override int SaveChanges()
        {
            HandleSoftDelete();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            HandleSoftDelete();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void HandleSoftDelete()
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(e =>
                    e.State == EntityState.Deleted &&
                    e.Entity is BaseEntity baseEntity &&
                    !(e.State == EntityState.Added)))
            {
                if (entry.Entity is Exam) // chỉ soft delete Exam
                {
                    entry.State = EntityState.Modified;
                    ((BaseEntity)entry.Entity).DeletedAt = DateTime.UtcNow;
                }

            }
        }


    }
}
