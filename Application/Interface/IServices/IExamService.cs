using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Exam;
using Application.DTOs.Question;
using Application.DTOs.ViewModel;
using Domain.Entities;

namespace Application.Interface.IServices
{
    public interface IExamService
    {
        Task<bool> CreateExamAsync(CreateExamDTO dto);
        Task<List<BankQuestion>> SearchBankQuestionsAsync(SearchBankQuestionFilter filter);
        Task<List<Subject>> GetAllSubjectsAsync();
        Task<List<QuestionType>> GetAllQuestionTypesAsync();
        Task<List<Level>> GetAllLevelsAsync();
        Task<QuestionDetailDTO?> GetQuestionDetailAsync(int questionId);
        public Task<ExamSubjectViewModel> GetAllExams(bool isPublic, string userId, string subjectId);
        public Task<ExamTakeDTO?> GetExamTakeById(int examId, string userId);
        public Task<int> SubmitExamAsync(ExamSubmitDTO dto, int ExamScoredId);
        Task<bool> UpdateBankQuestionAsync(UpdateBankQuestionDTO dto);
        Task<UpdateBankQuestionDTO?> GetBankQuestionByIdAsync(int id);
        Task<List<int>> GetRandomQuestionIdsAsync(int count, SearchBankQuestionFilter filter);
            Task<List<ExamDTO>> GetExamsByPremiumUserIdAsync(string premiumUserId);
        Task<ResultDTO> GrantExamAccessAsync(GrantExamAccessDTO dto, string grantedByPremiumUserId);
        Task<bool> DeleteExamAsync(int examId);
        Task CreateBankQuestionAsync(CreateBankQuestionDTO dto);

    }
}
