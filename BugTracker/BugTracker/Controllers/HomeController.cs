using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTracker.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LogIn si)
        {
            if (si.Name == "admin" && si.PassWord == "admin")
                ViewBag.Messages = "Wellcome admin!";
            else
                ViewBag.Messages = "Your name or password is wrong";
            return View("Thank");
        }
    }
}