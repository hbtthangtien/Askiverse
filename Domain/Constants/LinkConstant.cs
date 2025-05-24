using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Constants
{
	public class LinkConstant
	{
		public static string baseUri = $"https://localhost:7103";

		public static UriBuilder UriBuilder(string userId, string token, string path)
		{
			var builder = new UriBuilder(baseUri);
			builder.Path = $"account/{path}";
			builder.Query = $"userId={userId}&token={Uri.EscapeDataString(token)}";
			return builder ;
		}
	}
}
