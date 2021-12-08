using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVolait.Models;
using WebVolait.Repositorio;

namespace WebVolait.Controllers
{
    public class VendaController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Venda()
        {
            var venda = new Venda();
            return View(venda);
        }
        /*
        Acoes ac = new Acoes();
        [HttpPost]


        public ActionResult Venda(Venda venda)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarVenda(venda);
                    return RedirectToAction("ListarVenda");
                }
                return View(venda);
            }
            catch
            {
                return RedirectToAction("Venda");
            }
        }

        public ActionResult ListarVenda(Venda venda)
        {
            var ExibirVenda = new Acoes();
            var TodosVenda = ExibirVenda.ListarVenda();
            return View(TodosVenda);
        }*/

    }

}
