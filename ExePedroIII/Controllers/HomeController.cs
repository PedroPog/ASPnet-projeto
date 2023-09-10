using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExePedroIII.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Inicio()
        {
            return View();
        }
        public ActionResult Nota()
        {
            return View();
        }
        public ActionResult CalculaNota(int Nota)
        {
            if(Nota < 0 || Nota > 10)
            {
                TempData["erro"] = "Digite um valor valido!";
                return RedirectToAction("Nota");
            }
            else
            {
                ViewBag.NotaFinal = 10 - Nota;
                return View();
            }
        }

    }
}