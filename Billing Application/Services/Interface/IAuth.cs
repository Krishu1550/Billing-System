
using Billing_Application.Models;

namespace Billing_Application.Services.Interface
{
	public interface IAuth
	{
		Task<bool> Login(Account user);
		Task<bool> Registration();

	}
}
