using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila08.MVC.Web.Controllers
{
    public class ConsultaController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpPost]
        public ActionResult Excluir(int consultaId)
        {
            _unit.ConsultaRepository.Delete(consultaId);
            _unit.Save();
            TempData["msg"] = "Consulta excluida!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            CarregarPacientes();
            var consulta = _unit.ConsultaRepository.FindById(id);
            return View(consulta);
        }

        [HttpPost]
        public ActionResult Editar(Consulta consulta)
        {
            _unit.ConsultaRepository.Update(consulta);
            _unit.Save();
            TempData["msg"] = "Consulta atualizada";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var consultas = _unit.ConsultaRepository.List();
            return View(consultas);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarPacientes();
            return View();
        }

        private void CarregarPacientes()
        {
            var lista = _unit.PacienteRepository.List();
            ViewBag.pacientes = new SelectList(lista, "PacienteId", "Nome");
        }

        [HttpPost]
        public ActionResult Cadastrar(Consulta consulta)
        {
            _unit.ConsultaRepository.Insert(consulta);
            _unit.Save();
            TempData["msg"] = "Consulta cadastrada!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}