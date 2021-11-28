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
        // GET: Atendimento
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
       public ActionResult ListarAtendimento(Atendimento atendimento)
       {
           var ExibirAtendimento = new Acoes();
           var TodosAtendimento = ExibirAtendimento.ListarAtendimento();
           return View(TodosAtendimento);

       }*/
    }
}