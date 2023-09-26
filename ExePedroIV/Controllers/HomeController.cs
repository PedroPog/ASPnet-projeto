using ExePedroIV.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExePedroIV.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cliente(Cliente cliente)
        {
            return View(cliente);
        }
        public ActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("Cliente", cliente);
            }
            return View();
        }
        public ActionResult SelectLogin(string login) 
        {
            var dbExeQuartaApp = new Collection<string>
            {
                "Pratico",
                "Heitor",
                "Cicero"
            };
            return Json(dbExeQuartaApp.All(a=> a.ToLower() != login.ToLower()),JsonRequestBehavior.AllowGet);
        }
        public ActionResult SelectCpf(string cpf)
        {
            var dbExeQuartaApp = new Collection<string>
            {
                "11122233344",
                "22233344455",
                "33344455566"
            };
            return Json(dbExeQuartaApp.All(a => a != cpf.ToLower()), JsonRequestBehavior.AllowGet);
        }

        public JsonResult SelectData(DateTime dataCadastro)
        {
            return Json(dataCadastro.Date >= DateTime.Now.Date, JsonRequestBehavior.AllowGet);
        }

    }
}