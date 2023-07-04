using Billing_Application.Models;
using Billing_Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Billing_Application.Controllers
{
    public class AuthenticationController : Controller
    {
        IAuth _service;
        public AuthenticationController( IAuth auth)
        {
            _service = auth;
           
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Login(Account acount)
        {
            _service.Login(account);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Registeration() 
        {

            return View();       
        }

        public IActionResult Registeration(Register account)
        {

            return RedirectToAction("Index");

        }
    }
}
