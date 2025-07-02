using Application.DTOs.Exam;
using Application.DTOs.ExamScored;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IRepository
{
    public interface IExamRepository : IRepository<Exam>
    {
		public Task<List<Exam>> GetAllExams();
		public Task<ExamTakeDTO?> GetExamTakeById(int examId, string userId);
        public Task<int> SubmitExamAsync(ExamSubmitDTO dto, int ExamScoredId);
        Task<Exam?> GetByIdAsync(int id);
        Task<IEnumerable<Exam>> GetByPremiumUserIdAsync(string premiumUserId);
        Task<Exam?> GetExamWithRelationsAsync(int examId);
        public Task<int> CreateExamScored(int examId, string userId);
        Task<ExamFlashcardDTO?> GetExamForFlashcard(int examId, string userId);
        Task<ExamFlashcardDTO?> GetExamForPreview(int examId, string userId);

    }
}
