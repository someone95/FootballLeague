using PhonebookNET.Manager;
using PhonebookNET.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhonebookNET.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("Login", "Home");
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginVM loginVM)
        {
            AuthenticationManager.Authenticate(loginVM.Username, loginVM.Password);
            if (AuthenticationManager.LoggedUser == null)
                return RedirectToAction("Login", "Home");
            return RedirectToAction("Index", "Footballers");
        }
    }
}