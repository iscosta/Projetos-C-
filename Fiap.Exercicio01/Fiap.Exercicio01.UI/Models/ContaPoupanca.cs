using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio01.UI.Models
{
    public class ContaPoupanca : Conta, IContaInvestimento
    {
        //Field
        private readonly decimal _rendimento;
        //propriedade
        public decimal Taxa { get; set; }
        //Construtor
        public ContaPoupanca(decimal rend)
        {
            this._rendimento = rend;
        }

        public decimal CalcularRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Saldo >= (valor+Taxa))
            {
                Saldo -= (valor + Taxa);
            }
            else
            {
                throw new Exception("Saldo insuficiente");
            }
        }
    }
}
