using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVolait.Models;
using WebVolait.Repositorio;

namespace WebVolait.Controllers
{
    public class HospedagemController : Controller
    {
        // GET: Hospedagem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hospedagem()
        {
            var hospedagem = new Hospedagem();
            return View(hospedagem);
        }
    }
}