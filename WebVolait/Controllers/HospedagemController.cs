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
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Hospedagem()
        {
            var hospedagem = new Hospedagem();
            return View(hospedagem);
        }
        /*
        Acoes ac = new Acoes();
        [HttpPost]


        public ActionResult Hospedagem(Hospedagem hospedagem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarJogo(hospedagem);
                    return RedirectToAction("ListarHospedagem");
                }
                return View(hospedagem);
            }
            catch
            {
                return RedirectToAction("Hospedagem");
            }
        }

        public ActionResult ListarHospedagem(Hospedagem hospedagem)
        {
            var ExibirHospedagem = new Acoes();
            var TodosHospedagem = ExibirHospedagem.ListarHospedagem();
            return View(TodosHospedagem);
        }*/
    }
}