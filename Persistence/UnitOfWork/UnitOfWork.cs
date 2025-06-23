using Application.Interface.IRepository;
using Application.UnitOfWork;
using Persistence.DatabaseConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AskiverseContext _context;
        public IAnswerRepository Answers { get; private set; }

        public IBankQuestionRepository BankQuestions { get; private set; }

        public IBasicUserRepository BasicUsers { get; private set; }

        public IExamAccessRepository ExamAccess { get; private set; }

        public IExamAnsweredRepository ExamAnswereds { get; private set; }

        public IExamRepository Exams { get; private set; }

        public IExamScoredRepository ExamScoreds { get; private set; }

        public IForumPostRepository ForumPosts { get; private set; }

        public IForumCommentRepository ForumComments { get; private set; }

        public IForumVotedRepository ForumVoteds { get; private set; }

        public IHistoryPurchaseRepository HistoryPurchases { get; private set; }

        public ILevelRepository Levels { get; private set; }

        public INotificationRepository Notifications { get; private set; }

        public IPackageOfUserRepository PackageOfUsers { get; private set; }

        public IPremiumUserRepository PremiumUsers { get; private set; }

        public IProfileRepository Profiles { get; private set; }

        public IQuestionExamRepository QuestionExams { get; private set; }

        public IQuestionTypeRepository QuestionTypes { get; private set; }

        public ISubcriptionPackageRepository SubcriptionPackages { get; private set; }

        public ISubjectRepository Subjects { get; private set; }

        public IUserAccessExamRepository UserAccessExams { get; private set; }
        public IFavouriteRepository Favorites { get; private set; }
        public UnitOfWork(AskiverseContext context,
            IAnswerRepository answers,
            IBankQuestionRepository bankQuestions,
            IBasicUserRepository basicUsers,
            IExamAccessRepository examAccess,
            IExamAnsweredRepository examAnswereds,
            IExamRepository exams,
            IExamScoredRepository examScoreds,
            IForumPostRepository forumPosts,
            IForumCommentRepository forumComments,
            IForumVotedRepository forumVoteds,
            IHistoryPurchaseRepository historyPurchases,
            ILevelRepository levels,
            INotificationRepository notifications,
            IPackageOfUserRepository packageOfUsers,
            IPremiumUserRepository premiumUsers,
            IProfileRepository profiles,
            IQuestionExamRepository questionExams,
            IQuestionTypeRepository questionTypes,
            ISubcriptionPackageRepository subcriptionPackages,
            ISubjectRepository subjects,
            IUserAccessExamRepository userAccessExams,
          IFavouriteRepository favourite)
        {
            _context = context;
            Answers = answers;
            BankQuestions = bankQuestions;
            BasicUsers = basicUsers;
            ExamAccess = examAccess;
            ExamAnswereds = examAnswereds;
            Exams = exams;
            ExamScoreds = examScoreds;
            ForumPosts = forumPosts;
            ForumComments = forumComments;
            ForumVoteds = forumVoteds;
            HistoryPurchases = historyPurchases;
            Levels = levels;
            Notifications = notifications;
            PackageOfUsers = packageOfUsers;
            PremiumUsers = premiumUsers;
            Profiles = profiles;
            QuestionExams = questionExams;
            QuestionTypes = questionTypes;
            SubcriptionPackages = subcriptionPackages;
            Subjects = subjects;
            UserAccessExams = userAccessExams;
            Favorites = favourite;
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        public Task<int> CompleteAsync()
        {
            return _context.SaveChangesAsync();
        }

    }
}
