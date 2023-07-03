using Billing_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Billing_Application.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        { 
         
            return View();
        }

    }
}
