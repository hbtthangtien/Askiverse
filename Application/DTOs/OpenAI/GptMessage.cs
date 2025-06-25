using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.OpenAI
{
	public class GptMessage
	{
		public string Role { get; set; }
		public string Content { get; set; }
		public object Refusal { get; set; }
		public List<object> Annotations { get; set; }
	}

	public class GptChoice
	{
		public int Index { get; set; }
		public GptMessage Message { get; set; }
		public object Logprobs { get; set; }
		public string Finish_Reason { get; set; }
	}

	public class PromptTokensDetails
	{
		public int Cached_Tokens { get; set; }
		public int Audio_Tokens { get; set; }
	}

	public class CompletionTokensDetails
	{
		public int Reasoning_Tokens { get; set; }
		public int Audio_Tokens { get; set; }
		public int Accepted_Prediction_Tokens { get; set; }
		public int Rejected_Prediction_Tokens { get; set; }
	}

	public class Usage
	{
		public int Prompt_Tokens { get; set; }
		public int Completion_Tokens { get; set; }
		public int Total_Tokens { get; set; }
		public PromptTokensDetails Prompt_Tokens_Details { get; set; }
		public CompletionTokensDetails Completion_Tokens_Details { get; set; }
	}

	public class GptResponse
	{
		public string Id { get; set; }
		public string Object { get; set; }
		public long Created { get; set; }
		public string Model { get; set; }
		public List<GptChoice> Choices { get; set; }
		public Usage Usage { get; set; }
		public string Service_Tier { get; set; }
		public string System_Fingerprint { get; set; }
	}
}

