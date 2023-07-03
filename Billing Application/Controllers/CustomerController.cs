using Billing_Application.Models;
using Billing_Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Billing_Application.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomer _db;
        public CustomerController(ICustomer customer)
        {
            _db = customer;
        }


        public IActionResult Index(string layout)
        {
            ViewBag.Layout = layout;
            return View();
        }

        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int CustomerId)
        {
            return View();

        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteCustomer(int CustomerId)
        {
            return RedirectToAction("Index");
        }
    }
}
