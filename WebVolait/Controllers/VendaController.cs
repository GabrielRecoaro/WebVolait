using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVolait.Models;

namespace WebVolait.Controllers
{
    public class VendaController : Controller
    {
        // GET: Venda
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Venda()
        {
            var venda = new Venda();
            return View(venda);
        }
    }
}