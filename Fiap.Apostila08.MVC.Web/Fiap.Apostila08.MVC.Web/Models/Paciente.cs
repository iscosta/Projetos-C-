using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool PlanoSaude { get; set; }
        
        //Relacionamento One-To-Many
        public virtual List<Consulta> Consultas { get; set; }
    }
}