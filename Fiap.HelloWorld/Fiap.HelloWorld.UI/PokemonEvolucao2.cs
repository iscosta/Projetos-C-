using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI
{
    public class PokemonEvolucao2 : Pokemon
    {
        //Construtor que chama o construtor do pai
        public PokemonEvolucao2(string ataque, string nome, Sexo sexo) 
            : base(sexo, nome)
        {
            this.AtaqueEspecial = ataque;
        }

        public string AtaqueEspecial { get; set; }

        //Sobrescrever os métodos (Polimorfismo)
        public override void Atacar()
        {
            Console.WriteLine("Use o " + AtaqueEspecial);
        }

    }
}
