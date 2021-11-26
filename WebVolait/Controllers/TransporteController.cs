using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVolait.Models;

namespace WebVolait.Controllers
{
    public class TransporteController : Controller
    {
        // GET: Transporte
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Transporte()
        {
            var transporte = new Transporte();
            return View(transporte);
        }
    }
}