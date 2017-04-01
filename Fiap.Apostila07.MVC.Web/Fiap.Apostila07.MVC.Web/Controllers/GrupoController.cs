using Fiap.Apostila07.MVC.Web.Contexts;
using Fiap.Apostila07.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila07.MVC.Web.Controllers
{
    public class GrupoController : Controller
    {
        private AmContext _context = new AmContext();

        [HttpGet]
        public ActionResult Listar()
        {
            //Preenche também a propriedade Projeto do Grupo
            var listaGrupos = _context.Grupos.Include("Projeto").ToList();
            return View(listaGrupos);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(GrupoAm grupo)
        {
            _context.Grupos.Add(grupo);
            _context.SaveChanges();
            TempData["msg"] = "Grupo registrado!";
            return View();
        }
    }
}