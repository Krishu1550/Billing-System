using Billing_Application.Areas.Identity.Data;
using Billing_Application.Models;
using Billing_Application.Services.Interface;
using Microsoft.Identity.Client;

namespace Billing_Application.Services
{
	public class SAuth : IAuth
	{
		public Task<bool> Login(Account user)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Registration()
		{
			throw new NotImplementedException();
		}
	}
}
