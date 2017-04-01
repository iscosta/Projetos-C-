using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio01.UI.Models
{
    public abstract class Conta
    {
        //Propriedades
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal Saldo { get; set; }

        //Métodos
        public abstract void Retirar(decimal valor);
        public abstract void Depositar(decimal valor);
    }
}
