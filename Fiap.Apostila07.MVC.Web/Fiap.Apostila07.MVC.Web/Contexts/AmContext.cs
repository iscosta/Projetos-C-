using Fiap.Apostila07.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.Contexts
{
    public class AmContext : DbContext
    {
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<ProjetoAm> Projetos { get; set; }
        public DbSet<GrupoAm> Grupos { get; set; }
    }
}