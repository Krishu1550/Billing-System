using Billing_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Billing_Application.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetCustomer()
        {
            return View();
        }

        public IActionResult GetProduct(Customer customer)
        {
            return View();
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int CustomerId)
        {
            return View();

        }

    }
}
