using Fiap.Apostila08.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.Contexts
{
    public class AgendaContext : DbContext
    {
        public DbSet<Paciente>  Pacientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
    }
}