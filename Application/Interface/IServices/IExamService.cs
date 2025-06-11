using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Exam;
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
        public Task<List<ExamDTO>> GetAllExams();
        public Task<ExamTakeDTO?> GetExamTakeById(int examId, string userId);
        public Task<int> SubmitExamAsync(ExamSubmitDTO dto, int ExamScoredId);
    }
}
