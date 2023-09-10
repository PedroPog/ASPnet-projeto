using ExePedroIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExePedroIII.Areas.Veiculo.Controllers
{
    public class AutoController : Controller
    {
        // GET: Veiculo/Auto
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ConsultaMoto()
        {
            Moto moto = new Moto
            {
                Fabricante = "Ducati",
                Categoria = "Sport",
                Cilindrada = 998,
                Transmissao = "Automatica"

            };
            return View(moto);
        }
        public ActionResult ConsultaCarro()
        {
            Carro carro = new Carro 
            {
                Fabricante = "Chevrolet",
                Chassis = "Coupe",
                Nome = "Camaro",
                Tipo = "Automatica"
            };
            return View(carro);
        }
        public ActionResult ConsultaVeiculo()
        {
            Carro carro = new Carro();
            Moto moto = new Moto();

            ViewBag.carro = carro.Fabricante = "Chevrolet";
            ViewBag.chassis = carro.Chassis = "Coupe";
            ViewBag.nome = carro.Nome = "Camaro";
            ViewBag.tipo = carro.Tipo = "Automatica";

            ViewBag.fabricante = moto.Fabricante = "Ducati";
            ViewBag.categoria = moto.Categoria = "Sport";
            ViewBag.cilindrada = moto.Cilindrada = 998;
            ViewBag.transmissao = moto.Transmissao = "Automatica";


            return View();
        }
    }
}