using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.Models
{
    public class Consulta
    {
        public int ConsultaId { get; set; }
        public DateTime Data { get; set; }
        public string Especialidade { get; set; }
        public string Local { get; set; }

        //Relacionamento Many-To-One bidirecional
        public Paciente Paciente { get; set; }
        public int PacienteId { get; set; }
    }
}