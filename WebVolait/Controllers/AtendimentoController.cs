using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVolait.Models;
using WebVolait.Repositorio;

namespace WebVolait.Controllers
{
    public class AtendimentoController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Atendimento()
        {
            var atendimento = new Atendimento();
            return View(atendimento);
        }

        /*
         Acoes ac = new Acoes();
        [HttpPost]


        public ActionResult Atendimento(Antendimento atendimento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarAtendimento(atendimento);
                    return RedirectToAction("ListarAtendimento");
                }
                return View(atendimento);
            }
            catch
            {
                return RedirectToAction("Atendimento");
            }
        }

       public ActionResult ListarAtendimento(Atendimento atendimento)
       {
           var ExibirAtendimento = new Acoes();
           var TodosAtendimento = ExibirAtendimento.ListarAtendimento();
           return View(TodosAtendimento);

       }*/
    }
}