using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleContas.UI.Web.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }
    }
}