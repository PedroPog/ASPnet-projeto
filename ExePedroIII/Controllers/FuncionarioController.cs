using ExePedroIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExePedroIII.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CadastrarFunc() 
        {
            Funcionario funcionario = new Funcionario();
            return View(funcionario);
        }
        public ActionResult SelectFunc(Funcionario funcionario)
        {
            ViewBag.id = funcionario.Id;
            ViewBag.nome = funcionario.Nome;
            ViewBag.funcao = funcionario.Funcao;

            if (ViewBag.id <= 0 && ViewBag.nome == null && ViewBag.funcao == null)
            {
                TempData["erro"] = "";
                return RedirectToAction("CadastrarFunc");
            }
            if (ViewBag.id <= 0)
            {
                TempData["erro"] = "O campo codigo deve ser preenchido!";
                return RedirectToAction("CadastrarFunc");
            }
            if (ViewBag.nome == null)
            {
                TempData["erro"] = "O campo nome deve ser preenchido!";
                return RedirectToAction("CadastrarFunc");
            }
            if (ViewBag.funcao == null)
            {
                TempData["erro"] = "O campo funcao deve ser preenchido!";
                return RedirectToAction("CadastrarFunc");
            }
            return View();
        }
    }
}