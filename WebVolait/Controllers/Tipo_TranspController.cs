using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebVolait.Models;
using System.Web.Mvc;

namespace WebVolait.Controllers
{
    public class Tipo_TranspController : Controller
    {
        // GET: Tipo_Transp
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tipo_Transp()
        {
            var tipo_transp = new Tipo_Transp();
            return View(tipo_transp);
        }
    }
}