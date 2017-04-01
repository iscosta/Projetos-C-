using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI
{
    public class Pokemon
    {
        //Construtor
        public Pokemon(Sexo sexo, string nome)
        {
            this._sexo = sexo;
            this._nome = nome;
        }

        //Propriedades
        public int Nivel { get; set; }
        public List<string> Elemento { get; set; }
        
        //Campos (Atributos)
        private readonly Sexo _sexo;
        private string _nome;

        //Gets e Sets
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _nome = value;
            }
        }    
        
        //Métodos
        //virtual -> permite a sobrescrita do método na classe filha
        public virtual void Atacar()
        {
            Console.WriteLine("Vai " + _nome);         
        }

        public void Evoluir()
        {
            Nivel += 10;
        }

    }
}
