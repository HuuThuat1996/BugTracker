using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTracker.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Infomation info)
        {
            if (info.Attend == null)
            {
                ViewBag.Messages = "you must choose true or fasle";
            }
            else if (info.Attend == true)
            {
                ViewBag.Messages = "Welcome " + info.FullName + "to my party!";
            }
            else
            {
                ViewBag.Messages = "See you later!";
            }
            return View("Thank");

        }
    }
}