using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVolait.Models;

namespace WebVolait.Controllers
{
    public class PasseioController : Controller
    {
        // GET: Passeio
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Passeio()
        {
            var passeio = new Passeio();
            return View(passeio);
        }
    }
}