using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVolait.Models;
using WebVolait.Repositorio;

namespace WebVolait.Controllers
{
    public class Tipo_HospController : Controller
    {
        // GET: Tipo_Hosp
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tipo_Hosp()
        {
            var tipo_hosp = new Tipo_Hosp();
            return View(tipo_hosp);
        }
    }
}