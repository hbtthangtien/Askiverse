using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IExternalService
{
	public interface IEmailService
	{
		public Task SendMailAsync(string subject, string body, string email);
	}
}
