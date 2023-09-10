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
            return View();
        }
    }
}