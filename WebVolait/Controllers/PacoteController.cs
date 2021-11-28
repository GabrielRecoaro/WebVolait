using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVolait.Models;
using WebVolait.Repositorio;

namespace WebVolait.Controllers
{
    public class PacoteController : Controller
    {
        // GET: Pacote
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pacote()
        {
            var pacote = new Pacote();
            return View(pacote);
        }
    }
}