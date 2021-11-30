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
        /*
        Acoes ac = new Acoes();
        [HttpPost]


        public ActionResult Pacote(Pacote pacote)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarPacote(pacote);
                    return RedirectToAction("ListarPacote");
                }
                return View(pacote);
            }
            catch
            {
                return RedirectToAction("Pacote");
            }
        }

        public ActionResult ListarPacote(Pacote pacote)
        {
            var ExibirPacote = new Acoes();
            var TodosPacote = ExibirPacote.ListarPacote();
            return View(TodosPacote);
        */
    }
}