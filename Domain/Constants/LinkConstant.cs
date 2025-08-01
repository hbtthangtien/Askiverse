﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Constants
{
	public class LinkConstant
	{
		public static string baseUri = $"https://askiverse-h3b2ena6dcf0g6ez.australiaeast-01.azurewebsites.net";
		//public static string baseUri = $"https://localhost:7027";

		public static UriBuilder UriBuilder(string userId, string token, string path)
		{
			var builder = new UriBuilder(baseUri);
			builder.Path = $"basic-user/{path}";
			builder.Query = $"userId={userId}&token={Uri.EscapeDataString(token)}";
			return builder ;
		}
	}
}
