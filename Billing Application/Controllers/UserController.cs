using Microsoft.AspNetCore.Mvc;

namespace Billing_Application.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
