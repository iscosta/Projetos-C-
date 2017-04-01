using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.Models
{
    public class Professor
    {
        [Key]
        public int Pf { get; set; }
        public string Nome { get; set; }

        //Relacionamento Many-To-Many
        public virtual List<Aluno> Alunos { get; set; }
    }
}