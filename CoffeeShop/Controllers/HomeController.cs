using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.index = "Welcome to the Grand Circus Coffee Shop";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Registration";

            return View();
        }
        public ActionResult Result(Registration r)
        {
            ViewBag.name = r.prefix + " " + r.firstName + " " + r.lastName;

            return View();
        }
    }
}