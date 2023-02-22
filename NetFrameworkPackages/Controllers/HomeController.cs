using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetFrameworkPackages.Data;

namespace NetFrameworkPackages.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyContext context= new MyContext();
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
    }
}