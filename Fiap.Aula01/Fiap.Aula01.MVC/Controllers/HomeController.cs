using Fiap.Aula01.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Aula01.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Teste()
        {
            return View();
        }

        //Abrir a tela de cadastro
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Pessoa pessoa)
        {
            //Manda a informação para a View
            ViewBag.nome = pessoa.Nome;
            ViewBag.idade = pessoa.Idade;
            TempData["msg"] = "Cadastro realizado!";
            //Redirecionar para a tela Resultado.cshtml
            return View("Resultado");
            //return Content(pessoa.Nome + " - " + pessoa.Idade);
        }
    }
}