using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.Models
{
    public class GrupoAm
    {
        public int GrupoAmId { get; set; }
        public string Nome { get; set; }

        //Relacionamento one-to-one
        public ProjetoAm Projeto { get; set; }
        public int ProjetoAmId { get; set; }

        //Relacionamento one-to-many
        public virtual List<Aluno> Alunos { get; set; }
    }
}