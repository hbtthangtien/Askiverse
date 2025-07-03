using Application.DTOs.OpenAI;
using Application.DTOs.Question.GenerateAI;
using Application.Interface.IExternalService;
using Application.Interface.IServices;
using Domain.Constants;
using Domain.Entities;
using Infrastructure.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Infrastructure.ExternalService
{
    public class OpenAIService : IOpenAIService
    {
        private IExtractTextService _extractTextService;
        private IHttpClientFactory _httpClientFactory;
        private IBankQuestionService _bankQuestionService;
        public OpenAIService(IExtractTextService extractTextService,
            IHttpClientFactory httpClientFactory,
            IBankQuestionService bankQuestionService)
        {
            _extractTextService = extractTextService;
            _httpClientFactory = httpClientFactory;
            _bankQuestionService = bankQuestionService;
        }

        public async Task<List<QuestionCreate>> GenerateExamByAI(RequestGenerateAI request)
        {
            ValidFormatFile(request.File);
            var client = _httpClientFactory.CreateClient("OpenAI");
            var allQuestions = new List<QuestionCreate>();
            var chapters = _extractTextService.Extractext(request.File);
            var allChunks = new List<(string ChapterTitle, string ChunkText)>();
            foreach (var chapter in chapters)
            {
                var chapterChunks = TextExtension.SplitChunks(chapter.ChapterText, 800, 100);
                foreach (var chunk in chapterChunks)
                {
                    allChunks.Add((chapter.ChapterTitle, chunk));
                }
            }
            int totalChunks = allChunks.Count;
            int easyTotal = request.NumberEasyQuestion, medTotal = request.NumberMediumQuestion, hardTotal = request.NumberHardQuestion;
            int easyBase = easyTotal / totalChunks, easyRem = easyTotal % totalChunks;
            int medBase = medTotal / totalChunks, medRem = medTotal % totalChunks;
            int hardBase = hardTotal / totalChunks, hardRem = hardTotal % totalChunks;

            var plan = new List<(int Easy, int Med, int Hard)>();

            for (int i = 0; i < totalChunks; i++)
            {
                int addEasy = easyRem > 0 ? 1 : 0;
                int addMed = medRem > 0 ? 1 : 0;
                int addHard = hardRem > 0 && i < hardRem ? 1 : 0;

                plan.Add((
                    Easy: easyBase + addEasy,
                    Med: medBase + addMed,
                    Hard: hardBase + addHard
                ));

                if (easyRem > 0) easyRem--;
                if (medRem > 0) medRem--;
                if (hardRem > 0 && addHard == 1) hardRem--;
            }
            for (int i = 0; i < allChunks.Count; i++)
            {
                var (chapterTitle, chunkText) = allChunks[i];
                var (easy, med, hard) = plan[i];
                if (easy + med + hard == 0) continue;

                var prompt = BuildPromptWithChapter(chapterTitle, chunkText, easy, med, hard, request.QuestionTypeId);
                var json = JsonConvert.SerializeObject(prompt);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var responseJsonPrompt1 = await client.PostAsync("", content);
                var responseBody1 = await responseJsonPrompt1.Content.ReadAsStringAsync();
                var describeObject = JsonConvert.DeserializeObject<GptResponse>(responseBody1);
                // Deserialize
                try
                {
                    var questionJson = describeObject.Choices[0].Message.Content;
                    string cleanJson = Regex.Replace(questionJson, "^```json\\n|\\n```$", "", RegexOptions.Multiline);
                    var questions = JsonConvert.DeserializeObject<List<QuestionCreate>>(cleanJson);
                    if (questions != null) allQuestions.AddRange(questions);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi parse JSON chunk {i}: {ex.Message}");
                    // Có thể retry hoặc log lại prompt để kiểm tra
                    throw ex;
                }
            }
            return allQuestions;
        }
            private void ValidFormatFile(IFormFile file)
            {
                var allowedExts = new[] { ".pdf", ".docx", ".jpg", ".jpeg", ".png" };
                var filename = Path.GetExtension(file.FileName).ToLower();
                if (!allowedExts.Contains(filename))
                {
                    throw new Exception("Chỉ hỗ trợ file PDF, DOCX, JPG, PNG, JPEG.");
                }

                if (filename.Contains(".pdf"))
                {
                    var stream = file.OpenReadStream();
                    var totalPage = _extractTextService.ExtractTextFilePdfService.CountPagesPdfItext7(stream);
                    if (totalPage > 12)
                    {
                        throw new Exception("PDF vượt quá 20 trang.");
                    }
                }
                if (filename.Contains(".docx"))
                {
                    var stream = file.OpenReadStream();
                    var totalWords = _extractTextService.ExtractextFileDocService.CountWordDocx(stream);
                    if (totalWords > 12000)
                    {
                        throw new Exception("File vượt quá 12.000 từ");
                    }
                }
            }

            private ChatRequest BuildPromptWithChapter(string chapterTitle, string chunkText,
               int qEasy, int qMed, int qHard, int questionTypeId)
            {
                var totalQuestion = qEasy + qMed + qHard;
                var text = chapterTitle + "\n" + chunkText;
                var prompt = PromptAI.PROMPT_AI;
                prompt = prompt.Replace("{QUESTION_TYPE_ID}", questionTypeId.ToString())
                               .Replace("{TOTAL_QUESTIONS}", totalQuestion.ToString())
                               .Replace("{NUM_EASY}", qEasy.ToString())
                               .Replace("{NUM_MEDIUM}", qMed.ToString())
                               .Replace("{NUM_HARD}", qHard.ToString())
                               .Replace("{FULL_CHAPTER_TEXT}", text);

                var promptGenerateQuiz = new ChatRequest
                {
                    Model = "gpt-4o",
                    Messages = new List<Message>
                {
                    new Message
                    {
                        Role = "user",
                        Content = new List<ContentItem>
                        {
                            new ContentItem
                            {
                                Type = "text",
                                Text = prompt
                            }
                        }
                    }
                }
                };
                return promptGenerateQuiz;
            }
        }
    }
