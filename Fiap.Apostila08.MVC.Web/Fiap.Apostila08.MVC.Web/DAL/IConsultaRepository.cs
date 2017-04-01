using Fiap.Apostila08.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Apostila08.MVC.Web.DAL
{
    public interface IConsultaRepository
    {
        void Insert(Consulta consulta);
        void Update(Consulta consulta);
        void Delete(int id);
        Consulta FindById(int id);
        List<Consulta> List();
        List<Consulta> SearchFor(Expression<Func<Consulta,bool>> filtro);
    }
}
