using Application.DTOs.Exam;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IRepository
{
    public interface IExamScoredRepository : IRepository<ExamScored>
    {
        public Task<List<ExamScored>> GetAllExamScoredByUserIdByExamId(string userId, int examId);
        public Task<ExamScored?> GetExamScoredById(int examScoredId);
        public Task<ExamViewDetailsDTO?> GetExamDetails(int examScoredId, int examId);
    }
}
