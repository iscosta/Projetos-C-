using Fiap.Exercicio01.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio01.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar as classes ContaCorrente e ContaPoupanca
            var cc = new ContaCorrente()
            {
                Agencia = 2904,
                Numero = 8039,
                Saldo = 100,
                DataAbertura = new DateTime(2016,8,9),
                Tipo = TipoConta.Comum
            };
            var cp = new ContaPoupanca(0.06m)
            {
                Agencia = 2904,
                Numero = 8031,
                Saldo = 500,
                DataAbertura = new DateTime(2015,1,20),
                Taxa = 1
            };

            try
            {
                cc.Retirar(1000);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
