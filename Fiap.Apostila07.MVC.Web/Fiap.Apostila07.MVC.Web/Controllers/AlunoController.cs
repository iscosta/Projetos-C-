using Fiap.Apostila07.MVC.Web.Contexts;
using Fiap.Apostila07.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila07.MVC.Web.Controllers
{
    public class AlunoController : Controller
    {
        private AmContext _context = new AmContext();

        //Busca por Grupo de AM
        public ActionResult Buscar(int codigo)
        {
            //Filtra a lista de alunos
            var lista = _context.Alunos.Include("GrupoAm").Where(a => a.GrupoAmId == codigo).ToList();
            //Carrega as opções do Select
            var grupos = _context.Grupos.ToList();
            ViewBag.opcoes = new SelectList(grupos, "GrupoAmId", "Nome");
            //Retorna para a Listar.cshtml com a lista filtrada
            return View("Listar",lista);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var grupos = _context.Grupos.ToList();
            ViewBag.opcoes = new SelectList(grupos, "GrupoAmId", "Nome");
            var alunos = _context.Alunos.Include("GrupoAm").ToList();
            return View(alunos);
        }

        //Cadastrar um aluno
        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Buscar todos os grupos cadastrados
            var grupos = _context.Grupos.ToList();
            //Manda para a tela as informações para montar o select
            ViewBag.opcoes = new SelectList(grupos,"GrupoAmId","Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
            TempData["msg"] = "Aluno cadastrado";
            return Redirect("Cadastrar");
        }
    }
}