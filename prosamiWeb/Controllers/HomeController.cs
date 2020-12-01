using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prosamiWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string id)
        {
            ViewBag.Message = "Your application description page. You entered the ID " + id;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Gallery()
        {
            ViewBag.Message = "Your gallery page.";

            return View();
        }

        public ActionResult Funding()
        {
            ViewBag.Message = "Your funding page.";

            return View();
        }

        public ActionResult DevTeam()
        {
            ViewBag.Message = "Your funding page.";

            return View();
        }

        public ActionResult Orders()
        {
            ViewBag.Message = "Your funding page.";

            return View();
        }
    }
}