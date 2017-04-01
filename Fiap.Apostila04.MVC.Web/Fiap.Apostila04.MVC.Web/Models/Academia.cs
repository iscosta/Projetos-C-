using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Apostila04.MVC.Web.Models
{
    public class Academia
    {
        public string Cnpj { get; set; }
        public string Nome { get; set; }

        [Display(Name ="Número de Alunos")]
        public int NumeroAlunos { get; set; }

        public bool Piscina { get; set; }

        [Display(Name = "Data de Inscrição")]
        public DateTime DataInscricao { get; set; }
        public string Plano { get; set; }
    }
}