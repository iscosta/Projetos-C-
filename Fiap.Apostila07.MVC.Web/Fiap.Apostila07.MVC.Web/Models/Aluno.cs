using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.Models
{
    public class Aluno
    {
        [Key]
        public int Rm { get; set; }
        public string Nome { get; set; }

        //Relacionamento bidirecional
        public GrupoAm GrupoAm { get; set; }
        public int GrupoAmId { get; set; }

        //Relacionamento Many-To-Many
        public virtual List<Professor> Professores { get; set; }
    }
}