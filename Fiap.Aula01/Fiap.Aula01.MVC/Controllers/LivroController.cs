using Fiap.Aula01.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Aula01.MVC.Controllers
{
    public class LivroController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Livro livro)
        {
            ViewBag.livro = livro;
            TempData["mensagem"] = "Livro Cadastrado!";
            return View("Resultado");
        }
    }
}