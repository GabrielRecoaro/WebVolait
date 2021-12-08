using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebVolait.Models;

namespace WebVolait.Controllers
{
    public class ContaController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]

        public ActionResult Login(Login login, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);

            }

            var achou = (login.Usuario == "adm" && login.Senha == "123");

            if (achou)
            {
                FormsAuthentication.SetAuthCookie(login.Usuario, login.LembraMe);
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Login Inválido");
            }

            return View(login);
        }

    }
}