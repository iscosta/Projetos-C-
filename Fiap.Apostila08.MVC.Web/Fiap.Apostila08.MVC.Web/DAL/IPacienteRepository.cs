using Fiap.Apostila08.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Apostila08.MVC.Web.DAL
{
    public interface IPacienteRepository
    {
        void Insert(Paciente paciente);
        List<Paciente> List();
    }
}
