using Fiap.Apostila04.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila04.MVC.Web.Controllers
{
    public class AcademiaController : Controller
    {
        //Simular o banco de dados
        private static List<Academia> _lista = new List<Academia>();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Passar a lista de planos para a tela (select)
            List<string> planos = new List<string>();
            planos.Add("Ouro");
            planos.Add("Prata");
            planos.Add("Bronze");
            ViewBag.opcoes = new SelectList(planos);
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Academia academia)
        {
            _lista.Add(academia); //Adiciona a academia na lista
            TempData["mensagem"] = "Academia cadastrada.";
            return Redirect("Cadastrar"); //Redireciona para o cadastrar
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //ViewBag.samurai = _lista;
            //Passa a lista para a tela
            return View(_lista);
        }
    }
}