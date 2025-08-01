﻿using Application.DTOs.Question.GenerateAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IExternalService
{
    public interface IOpenAIService
    {
        public Task<List<QuestionCreate>> GenerateExamByAI(RequestGenerateAI request);
    }
}
