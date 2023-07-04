using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Billing_Application.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Billing_ApplicationUser class
public class Billing_ApplicationUser : IdentityUser
{
	public int AccountId { get; set; }

	public string UserName { get; set; }

	public string Password { get; set; }

	public string Role { get; set; }
}

