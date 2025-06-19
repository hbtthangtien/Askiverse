using Application.Interface.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IAnswerRepository Answers { get; }

        public IBankQuestionRepository BankQuestions { get; }

        public IBasicUserRepository BasicUsers { get; }

        public IExamAccessRepository ExamAccess { get; }

        public IExamAnsweredRepository ExamAnswereds { get; }

        public IExamRepository Exams { get; }

        public IExamScoredRepository ExamScoreds { get; }

        public IForumPostRepository ForumPosts { get; }

        public IForumCommentRepository ForumComments { get; }

        public IForumVotedRepository ForumVoteds { get; }

        public IHistoryPurchaseRepository HistoryPurchases { get; }

        public ILevelRepository Levels { get; }

        public INotificationRepository Notifications { get; }

        public IPackageOfUserRepository PackageOfUsers { get; } 

        public IPremiumUserRepository PremiumUsers { get; }

        public IProfileRepository Profiles { get; }

        public IQuestionExamRepository QuestionExams { get; }

        public IQuestionTypeRepository QuestionTypes { get; }

        public ISubcriptionPackageRepository SubcriptionPackages { get; }

        public ISubjectRepository Subjects { get; }

        public IUserAccessExamRepository UserAccessExams { get; }

        public IFavouriteRepository Favorites { get; }

        public Task CommitAsync();
    }
}
