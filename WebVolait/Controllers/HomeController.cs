using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebVolait.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            ViewBag.Message = "Sua página para mais informações";

            return View();
        }

        public ActionResult Contato()
        {
            ViewBag.Message = "Sua página para contato";

            return View();
        }
    }
}