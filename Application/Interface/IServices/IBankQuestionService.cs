using Application.DTOs.Question.GenerateAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IServices
{
    public interface IBankQuestionService
    {
        public Task CreateQuestionByAI(List<QuestionCreate> list);
    }
}
