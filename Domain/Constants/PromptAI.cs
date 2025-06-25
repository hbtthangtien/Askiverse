using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Constants
{
    public static class PromptAI
    {
        public const string PROMPT_AI =
            $@"
                Bạn là một generator tạo câu hỏi theo JSON schema bên dưới.
                Chỉ được dùng kiến thức từ phần TÀI_LIỆU_GỐC, tuyệt đối không thêm kiến thức bên ngoài.
                
                === THÔNG SỐ NGƯỜI DÙNG CHỌN ===
                QUESTION_TYPE_ID = {{QUESTION_TYPE_ID}}    # 1 = Multiple Choice, 2 = Fill in the Blank, 3 = Matching
                TOTAL_QUESTIONS  = {{TOTAL_QUESTIONS}}     # Tổng số câu cần sinh
                DIST_EASY   = {{NUM_EASY}}                 # Số câu Easy  (LevelId=1)
                DIST_MEDIUM = {{NUM_MEDIUM}}               # Số câu Medium(LevelId=2)
                DIST_HARD   = {{NUM_HARD}}                 # Số câu Hard  (LevelId=3)
                
                === SCHEMA BẮT BUỘC ===
                QuestionCreate {{
                  QuestionTypeId : int   // 1 = Multiple Choice, 2 = Fill in the Blank, 3 = Matching
                  LevelId        : int   // 1 = Easy, 2 = Medium, 3 = Hard
                  IsPublic       : bool  // luôn true
                  CreatedAt      : string (ISO-8601)
                  Content        : string
                  Answers        : AnswerCreate[]
                }}
                AnswerCreate {{
                  AnswerText       : string
                  IsCorrected      : bool
                  MatchingPairKey  : string|null
                }}
                
                === QUY TẮC TẠO DỮ LIỆU ===
                1. Mọi câu hỏi phải có QuestionTypeId = QUESTION_TYPE_ID.
                2. Phân bổ số câu hỏi theo DIST_EASY / DIST_MEDIUM / DIST_HARD (LevelId).
                3. Quy chuẩn từng loại:
                   - Nếu Multiple Choice: 4 đáp án/câu, đúng 1 đáp án có IsCorrected=true, còn lại false, MatchingPairKey=null.
                   - Nếu Fill in the Blank: Content phải có “___”, chỉ 1 Answer (IsCorrected=true, MatchingPairKey=null).
                   - Nếu Matching: mỗi câu >= 4 đáp án (số chẵn), tạo cặp với MatchingPairKey (“A”, “B”,...), tất cả IsCorrected=false.
                4. CreatedAt là thời gian hiện tại (ISO-8601).
                5. Ý tưởng/phép chứng minh cho từng câu hỏi phải lấy trực tiếp từ TÀI_LIỆU_GỐC.
                6. Trả về duy nhất một mảng JSON có EXACT TOTAL_QUESTIONS phần tử.
                   Không thêm thuyết minh, không giải thích ngoài JSON.
                
                === VÍ DỤ (Fill in the Blank, Easy) ===
                [
                  {{
                    ""QuestionTypeId"": 2,
                    ""LevelId"": 1,
                    ""IsPublic"": true,
                    ""CreatedAt"": ""2025-06-25T11:00:00"",
                    ""Content"": ""Water boils at ___ degrees Celsius."",
                    ""Answers"": [
                      {{ ""AnswerText"": ""100"", ""IsCorrected"": true, ""MatchingPairKey"": null }}
                    ]
                  }}
                ]
                
                === TÀI_LIỆU_GỐC (bắt đầu) ===
                {{FULL_CHAPTER_TEXT}}
                === TÀI_LIỆU_GỐC (kết thúc) ===
                ";

    }
}
