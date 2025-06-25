using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.OpenAI
{
	public class ChatRequest
	{
		[JsonProperty("model")]
		public string Model { get; set; }

		[JsonProperty("messages")]
		public List<Message> Messages { get; set; }
	}

	public class Message
	{
		[JsonProperty("role")]
		public string Role { get; set; }

		[JsonProperty("content")]
		public List<ContentItem> Content { get; set; }
	}

	public class ContentItem
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
		public string Text { get; set; }

		[JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
		public ImageUrl ImageUrl { get; set; }
	}

	public class ImageUrl
	{
		[JsonProperty("url")]
		public string Url { get; set; }
	}
}
