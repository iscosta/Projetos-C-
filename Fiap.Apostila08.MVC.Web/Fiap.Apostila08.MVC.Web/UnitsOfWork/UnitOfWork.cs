using Fiap.Apostila08.MVC.Web.Contexts;
using Fiap.Apostila08.MVC.Web.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.UnitsOfWork
{
    public class UnitOfWork : IDisposable
    {
        //Contexto
        private AgendaContext _context = new AgendaContext();

        //propfull  -> tab tab
        private IPacienteRepository _pacienteRepository;

        public IPacienteRepository PacienteRepository
        {
            get
            {
                if (_pacienteRepository == null)
                {
                    _pacienteRepository = new PacienteRepository(_context);
                }
                return _pacienteRepository;
            }
        }

        //propfull  -> tab tab
        private IConsultaRepository _consultaRepository;

        public IConsultaRepository ConsultaRepository
        {
            get
            {
                if (_consultaRepository == null)
                {
                    _consultaRepository = new ConsultaRepository(_context);
                }
                return _consultaRepository;
            }
        }

        //SaveChanges
        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;

        public void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _context.Dispose();
            }
            _disposed = true;
        }

        //Fechar a conexão... liberar o recurso
        public void Dispose()
        {
            this.Dispose(true); //Libera a conexão do context
            GC.SuppressFinalize(this); //Finaliza o UnitOfWork
        }
    }
}