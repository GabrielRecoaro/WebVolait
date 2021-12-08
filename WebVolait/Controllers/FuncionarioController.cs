using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVolait.Models;
using WebVolait.Repositorio;

namespace WebVolait.Controllers
{
    public class FuncionarioController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Funcionario()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }/*

        Acoes ac = new Acoes();

        [HttpPost]

        public ActionResult Funcionario(Funcionario funcionario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarFuncionario(funcionario);
                    return RedirectToAction("ListarFuncionario");
                }
                return View(funcionario);
            }
            catch
            {
                return RedirectToAction("Funcionario");
            }
        }

        public ActionResult ListarFuncionario(Funcionario funcionario)
        {
            var ExibirFunc = new Acoes();
            var TodosFunc = ExibirFunc.ListarFuncionario();
            return View(TodosFunc);

        }*/

    }
}