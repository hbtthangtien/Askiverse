using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Exam
{
    public class ResultDTO
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public static ResultDTO Success(string message) => new ResultDTO { IsSuccess = true, Message = message };
        public static ResultDTO Fail(string message) => new ResultDTO { IsSuccess = false, Message = message };
    }

}
