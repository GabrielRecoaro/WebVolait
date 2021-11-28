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
        // GET: Cliente
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
       public ActionResult ListarCliente(Cliente cliente)
       {
           var ExibirCliente = new Acoes();
           var TodosCliente = ExibirCliente.ListarCliente();
           return View(TodosCliente);

       }*/

    }
}