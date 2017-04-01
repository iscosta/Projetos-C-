using Fiap.Apostila06.MVC.Web.Contexts;
using Fiap.Apostila06.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila06.MVC.Web.Controllers
{
    public class ContatoController : Controller
    {
        private AgendaContext _context = new AgendaContext();

        [HttpGet]
        public ActionResult Buscar(string nomeBusca)
        {
            //Buscar por nome
            var lista = _context.Contatos.Where(c => c.Nome.Contains(nomeBusca)).ToList();
            //Abre a tela Listar.cshtml passando a lista filtrada
            return View("Listar",lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Contato contato)
        {
            //Cadastra no Banco de Dados
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            //Mensagem de sucesso
            TempData["msg"] = "Contato registrado!";
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Buscar os contatos cadastrados no banco de dados
            var lista = _context.Contatos.ToList();
            //Manda a lista para a view
            return View(lista);
        }

        //Abre a tela com o formulário preenchido
        [HttpGet]
        public ActionResult Alterar(int id)
        {
            //Buscar o contato no banco de dados
            var contato = _context.Contatos.Find(id);
            //Mandar o contato pra a view
            return View(contato);
        }

        [HttpPost]
        public ActionResult Alterar(Contato contato)
        {
            //Atualizar no banco de dados
            _context.Entry(contato).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            //Mensagem de sucesso
            TempData["msg"] = "Alterado!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            //Busca o contato
            var contato = _context.Contatos.Find(id);
            //Remove o contato
            _context.Contatos.Remove(contato);
            _context.SaveChanges();
            //Mensagem
            TempData["msg"] = "Contato removido!";
            return RedirectToAction("Listar");
        }
    }
}