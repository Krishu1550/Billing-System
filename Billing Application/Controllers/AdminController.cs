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
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            return View();
        }

        [HttpGet]
        public IActionResult UpdateProduct(int ProductId)
        {

            return View();
        
        }


        [HttpPost]
        public IActionResult UpdateProduct(Product product) 
        {
            return View();
        
        }


        [HttpGet]

        public IActionResult DeleteProduct(int ProductId)
        {

            return View();
        }

    }
}
