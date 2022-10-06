using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXPLORANDO_O_C_.models
{
    public class Pessoa

    {
        private string _Nome;
        private int _Idade;
        public string Nome 
        { 
            get => _Nome.ToUpper(); //ouy usar o return_Nome.ToUpper();usado com chaves
            

            set{

                if(value == ""){

                throw new ArgumentException("o NOME não pode ser vazio.");

                }

                _Nome = value;
                
            }
            
        }
        public int Idade 
        { 
            get => _Idade; 
            
            set{ // autenticação de idade

                if(value < 0){

                    throw new ArgumentException("Idade não pode ser menor que zero.");

                }
                _Idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Meu Nome é {Nome}, minha Idade é {Idade} ");
        }

    }
}