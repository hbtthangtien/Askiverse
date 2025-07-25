﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Commons;
using Application.DTOs.Exam;
using Application.DTOs.Question;
using Application.DTOs.Question.GenerateAI;
using Application.DTOs.ViewModel;
using Domain.Entities;

namespace Application.Interface.IServices
{
	public interface IExamService
	{
		Task<int> CreateExamAsync(CreateExamDTO dto);
		Task<List<BankQuestion>> SearchBankQuestionsAsync(SearchBankQuestionFilter filter, string? PremiumUserId);
		Task<List<Subject>> GetAllSubjectsAsync();
		Task<List<QuestionType>> GetAllQuestionTypesAsync();
		Task<List<Level>> GetAllLevelsAsync();
		Task<QuestionDetailDTO?> GetQuestionDetailAsync(int questionId);
		public Task<ExamSubjectViewModel> GetAllExams(bool isPublic, string userId, string subjectId, string? questionCount, string? sortOrder, string? keyword, bool isFavourite, int pageIndex, int pageSize);
		public Task<ExamTakeDTO?> GetExamTakeById(int examId, string userId);
		public Task<int> SubmitExamAsync(ExamSubmitDTO dto, int ExamScoredId);
		Task<bool> UpdateBankQuestionAsync(UpdateBankQuestionDTO dto);
		Task<UpdateBankQuestionDTO?> GetBankQuestionByIdAsync(int id);
		Task<List<int>> GetRandomQuestionIdsAsync(int count, SearchBankQuestionFilter filter, string? PremiumUserId);
		Task<List<ExamDTO>> GetExamsByPremiumUserIdAsync(string premiumUserId);
		Task<ResultDTO> GrantExamAccessAsync(GrantExamAccessDTO dto, string grantedByPremiumUserId);
		Task<bool> DeleteExamAsync(int examId, string userId);
		Task CreateBankQuestionAsync(CreateBankQuestionDTO dto);
		Task<EditExamDTO> GetExamForEditAsync(int examId);
		Task<bool> UpdateExamAsync(EditExamDTO dto);
		public Task<int> CreateExamScoredAsync(int examId, string userId);
		Task<List<SimpleQuestionDto>> GetQuestionsByIdsAsync(List<int> questionIds);
		Task<ExamFlashcardDTO?> GetExamForFlashcard(int examId, string userId);
		Task<ExamFlashcardDTO?> GetExamForPreview(int examId, string userId);
		Task<IdResponse> SaveExamGeneratedByAi(SaveExamDTO dto);
		Task<byte[]> ExportExamToDocxFile(long examId);
  }
}
