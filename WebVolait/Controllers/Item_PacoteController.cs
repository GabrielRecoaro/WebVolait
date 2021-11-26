using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebVolait.Models;
using System.Web.Mvc;

namespace WebVolait.Controllers
{
    public class Item_PacoteController : Controller
    {
        // GET: Item_Pacote
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Item_Pacote()
        {
            var item_pacote = new Item_Pacote();
            return View(item_pacote);
        }
    }
}