using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.Models
{
    public class ProjetoAm
    {
        public int ProjetoAmId { get; set; }

        [Display(Name = "Título")]
        public string Titulo { get; set; }

        public string Tema { get; set; }

        [Display(Name ="Data de Entrega")]
        public DateTime DataEntrega { get; set; }
    }
}