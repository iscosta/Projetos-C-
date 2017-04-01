using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila08.MVC.Web.Controllers
{
    public class PacienteController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Paciente paciente)
        {
            //Cadastrar o paciente no banco
            _unit.PacienteRepository.Insert(paciente);
            _unit.Save();
            //Mensagem de sucesso
            TempData["msg"] = "Paciente cadastrado";
            return RedirectToAction("Cadastrar");
        }

        //Liberar a conexão com o banco de dados
        protected override void Dispose(bool disposing)
        {
            _unit.Dispose(); 
            base.Dispose(disposing);    
        }
    }
}