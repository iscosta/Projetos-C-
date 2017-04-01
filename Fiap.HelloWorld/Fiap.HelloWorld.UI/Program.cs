using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon(Sexo.Feminino, "Charmander");
            pokemon.Nome = "Charmander"; //set
            Console.WriteLine(pokemon.Nome); //get

            PokemonEvolucao2 charmeleon = 
                new PokemonEvolucao2("Fireblast","Charmeleon",Sexo.Masculino)
            {
                Nome = "Charmeleon",
                AtaqueEspecial = "Fireblast"
            };

            Console.ReadLine(); //Para a execução
        }
    }
}
