using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTracker.Controllers
{
    public class TesterManagerController : Controller
    {
        // GET: TesterManager
        [HttpGet]
        public ActionResult TesterManager()
        {
            TesterManager tester = new TesterManager();
            return View(tester);
        }
        [HttpPost]
        public ActionResult TesterManager(TesterManager tester)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Tester" + tester.UserName + " is added";
            }
            return View(tester);
        }
    }
}