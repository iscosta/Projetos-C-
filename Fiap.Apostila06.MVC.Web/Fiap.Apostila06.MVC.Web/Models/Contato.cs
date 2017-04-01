using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap.Apostila06.MVC.Web.Models
{
    public class Contato
    {
        public int ContatoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        
        [Required]
        public string Telefone { get; set; }

        [Column("DT_NASCIMENTO")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        public bool Familiar { get; set; }
    }
}