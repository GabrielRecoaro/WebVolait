using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebVolait.Models;
using System.Web.Mvc;
using WebVolait.Repositorio;

namespace WebVolait.Controllers
{
    public class ClienteController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Cliente()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        /*
          
         Acoes ac = new Acoes();
        [HttpPost]

        public ActionResult Cliente(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarCliente(cliente);
                    return RedirectToAction("ListarCliente");
                }
                return View(cliente);
            }
            catch
            {
                return RedirectToAction("Cliente");
            }
        }

       public ActionResult ListarCliente(Cliente cliente)
       {
           var ExibirCliente = new Acoes();
           var TodosCliente = ExibirCliente.ListarCliente();
           return View(TodosCliente);

       }*/

    }
}