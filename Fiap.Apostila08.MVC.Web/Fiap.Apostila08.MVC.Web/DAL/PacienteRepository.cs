using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.Contexts;

namespace Fiap.Apostila08.MVC.Web.DAL
{
    public class PacienteRepository : IPacienteRepository
    {
        private AgendaContext _context;

        //Construtor
        public PacienteRepository(AgendaContext context)
        {
            _context = context;
        }

        public void Insert(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
        }

        public List<Paciente> List()
        {
            return _context.Pacientes.ToList();
        }
    }
}