using Billing_Application.Models;
using Billing_Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Billing_Application.Controllers
{
    public class ProductController : Controller
    {

        private IProduct _db;

        public ProductController(IProduct product )
        {

            _db = product;

        }

        public IActionResult Index(string layout)
        {
            ViewBag.Layout = layout;
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
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int ProductId)
        {

            return View();

        }


        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            return RedirectToAction("Index");

        }


        [HttpGet]

        public IActionResult DeleteProduct(int ProductId)
        {

            return RedirectToAction("Index");
        }

    }
}
