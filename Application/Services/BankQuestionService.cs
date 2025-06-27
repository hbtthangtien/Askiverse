using Application.DTOs.Question.GenerateAI;
using Application.Interface.IExternalService;
using Application.Interface.IServices;
using Application.UnitOfWork;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class BankQuestionService : Service, IBankQuestionService
    {
        private readonly IUserContextService _userContext;

        public BankQuestionService(IUnitOfWork unitOfWork,
            IMapper mapper,
            IUserContextService userContextService) : base(unitOfWork, mapper)
        {
            _userContext = userContextService;
        }

        public async Task CreateQuestionByAI(List<QuestionCreate> list)
        {
            var data = list.Select(e => new BankQuestion
            {
                Content = e.Content,
                CreatedAt = DateTime.Now,
                IsPublic = true,
                LevelId = e.LevelId,
                QuestionTypeId = e.QuestionTypeId,
                PremiumUserId = null,
                Answers = e.Answers.Select(a => new Answer
                {
                    AnswerText = a.AnswerText,
                    IsCorrected = a.IsCorrected,
                    MatchingPairKey = a.MatchingPairKey,                         
                }).ToList()
            }).ToList() ;
            await _unitOfWork.BankQuestions.AddRange(data);
            await _unitOfWork.CommitAsync();
        }
    }
}
