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
                      QUESTION_TYPE_ID = {{{{QUESTION_TYPE_ID}}}}    # 1 = Multiple Choice, 2 = Fill in the Blank, 3 = Matching
                      TOTAL_QUESTIONS  = {{{{TOTAL_QUESTIONS}}}}     # Tổng số câu cần sinh
                      DIST_EASY   = {{{{NUM_EASY}}}}                 # Số câu Easy  (LevelId=1)
                      DIST_MEDIUM = {{{{NUM_MEDIUM}}}}               # Số câu Medium(LevelId=2)
                      DIST_HARD   = {{{{NUM_HARD}}}}                 # Số câu Hard  (LevelId=3)
                      
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
                      0. Ngôn ngữ câu hỏi và câu trả lời PHẢI HOÀN TOÀN TRÙNG VỚI ngôn ngữ của TÀI_LIỆU_GỐC, không được lẫn lộn hoặc tự ý thay đổi.
                      1. Mọi câu hỏi phải có QuestionTypeId = QUESTION_TYPE_ID.
                      2. Phân bổ số câu hỏi đúng theo DIST_EASY / DIST_MEDIUM / DIST_HARD (LevelId).
                      3. Quy chuẩn từng loại:
                         - Nếu Multiple Choice: 
                            + Mỗi câu hỏi luôn có đủ 4 đáp án.
                            + Chỉ đúng 1 đáp án có IsCorrected=true, 3 đáp án còn lại là false, MatchingPairKey=null.
                            + Vị trí đáp án đúng phải được phân bố ngẫu nhiên và đều nhau giữa các vị trí (không tập trung vào A).
                         - Nếu Fill in the Blank:
                            + Nội dung câu hỏi phải chứa “___” để người dùng điền vào chỗ trống.
                            + Chỉ có 1 Answer duy nhất (IsCorrected=true, MatchingPairKey=null).
                         - Nếu Matching:
                            + Mỗi câu phải có ít nhất 4 đáp án (số chẵn), chia thành từng cặp có MatchingPairKey tương ứng (""A"", ""B"",...), toàn bộ IsCorrected=false.
                      4. CreatedAt là thời gian hiện tại (ISO-8601).
                      5. Mọi câu hỏi phải được xây dựng TRỰC TIẾP dựa trên thông tin từ TÀI_LIỆU_GỐC, tuyệt đối không thêm thông tin bên ngoài.
                      6. Luôn trả về duy nhất một mảng JSON với chính xác TOTAL_QUESTIONS phần tử.
                         Tuyệt đối không thêm thuyết minh, không thêm giải thích ngoài JSON.
                      
                      === VÍ DỤ (Fill in the Blank, Easy) ===
                      [
                        {{
                          ""QuestionTypeId"": 2,
                          ""LevelId"": 1,
                          ""IsPublic"": true,
                          ""CreatedAt"": ""2025-06-25T11:00:00"",
                          ""Content"": ""Nước sôi ở ___ độ C."",
                          ""Answers"": [
                            {{ ""AnswerText"": ""100"", ""IsCorrected"": true, ""MatchingPairKey"": null }}
                          ]
                        }}
                      ]
                      
                      === TÀI_LIỆU_GỐC (bắt đầu) ===
                      {{{{FULL_CHAPTER_TEXT}}}}
                      === TÀI_LIỆU_GỐC (kết thúc) ===

                ";

    }
}
