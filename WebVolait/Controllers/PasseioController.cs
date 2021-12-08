using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVolait.Models;
using WebVolait.Repositorio;

namespace WebVolait.Controllers
{
    public class PasseioController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult Passeio()
        {
            var passeio = new Passeio();
            return View(passeio);
        }
        
        /*
        Acoes ac = new Acoes();
        [HttpPost]


        public ActionResult Passeio(Passeio passseio)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarPasseio(passeio);
                    return RedirectToAction("ListarPasseio");
                }
                return View(passeio);
            }
            catch
            {
                return RedirectToAction("Passeio");
            }
        }

        public ActionResult ListarPasseio(Passeio passeio)
        {
            var ExibirPasseio = new Acoes();
            var TodosPasseio = ExibirPasseio.ListarPasseio();
            return View(TodosPasseio);
        }*/
    }
}