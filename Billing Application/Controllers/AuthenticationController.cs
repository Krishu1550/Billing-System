using Microsoft.AspNetCore.Mvc;

namespace Billing_Application.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
