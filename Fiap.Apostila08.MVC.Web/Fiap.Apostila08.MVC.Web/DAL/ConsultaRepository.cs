using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.Contexts;

namespace Fiap.Apostila08.MVC.Web.DAL
{
    public class ConsultaRepository : IConsultaRepository
    {
        private AgendaContext _context;

        //Construtor que recebe o "EntityManager" context... ctor -> tab tab
        public ConsultaRepository(AgendaContext context)
        {
            this._context = context;
        }

        public void Delete(int id)
        {
            var consulta = _context.Consultas.Find(id);
            _context.Consultas.Remove(consulta);
        }

        public Consulta FindById(int id)
        {
            return _context.Consultas.Find(id);
        }

        public void Insert(Consulta consulta)
        {
            _context.Consultas.Add(consulta);
        }

        public List<Consulta> List()
        {
            return _context.Consultas.Include("Paciente").ToList();
        }

        public List<Consulta> SearchFor(Expression<Func<Consulta, bool>> filtro)
        {
            return _context.Consultas.Where(filtro).ToList();
        }

        public void Update(Consulta consulta)
        {
            _context.Entry(consulta).State = System.Data.Entity.EntityState.Modified;
        }
    }
}