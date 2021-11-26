using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVolait.Models;

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
    }
}