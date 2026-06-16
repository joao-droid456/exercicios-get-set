using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Pessoa
    {
        private int _idade;
        private int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Menor de Idade");
                }
                else
                {
                    Console.WriteLine("Você é maior de idade");

                    _idade = value;
                }
            }
        }
        public void Decreto(int idade)
        {
            Idade = idade;

            Console.WriteLine(_idade);
        }
    }
}