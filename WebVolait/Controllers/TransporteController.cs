using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVolait.Models;
using WebVolait.Repositorio;

namespace WebVolait.Controllers
{
    public class TransporteController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Transporte()
        {
            var transporte = new Transporte();
            return View(transporte);
        }
        /*
        Acoes ac = new Acoes();
        [HttpPost]


        public ActionResult Transporte(Transporte transporte)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarTransporte(transporte);
                    return RedirectToAction("ListarTransporte");
                }
                return View(transporte);
            }
            catch
            {
                return RedirectToAction("Transporte");
            }
        }

        public ActionResult ListarTransporte(Transporte transporte)
        {
            var ExibirTransporte = new Acoes();
            var TodosTransporte = ExibirTransporte.ListarTransporte();
            return View(TodosTransporte);
        }*/
    }
}