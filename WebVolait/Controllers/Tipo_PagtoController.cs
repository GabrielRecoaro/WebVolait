using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVolait.Models;
using WebVolait.Repositorio;

namespace WebVolait.Controllers
{
    public class Tipo_PagtoController : Controller
    {
        // GET: Tipo_Pagto
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tipo_Pagto()
        {
            var tipo_pagto = new Tipo_Pagto();
            return View(tipo_pagto);
        }

    }
}