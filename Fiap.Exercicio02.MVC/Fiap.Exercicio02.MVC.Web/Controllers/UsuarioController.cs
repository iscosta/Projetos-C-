using Fiap.Exercicio02.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exercicio02.MVC.Web.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet] //Abre a página
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Usuario usuario)
        {
            TempData["msg"] = "Cadastrado!";
            return View("Resultado",usuario);//Abre a página Resultado.cshtml
        }
    }
}