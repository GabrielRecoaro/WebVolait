using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebVolait.Models;
using System.Web.Mvc;
using WebVolait.Repositorio;

namespace WebVolait.Controllers
{
    public class Item_VendaController : Controller
    {
        // GET: Item_Venda
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Item_Venda()
        {
            var item_venda = new Item_Venda();
            return View(item_venda);
        }
    }
}