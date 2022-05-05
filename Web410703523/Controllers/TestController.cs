using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410703523.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HW1()
        {
            return View();
        }

        public ActionResult HW2()
        {
            return View();
        }
        public ActionResult HW3()
        {
            ViewBag.name = "ting";
            ViewData["weight"] = "0";
            ViewData["water"] = "0";
            return View();
        }
        
    }
}