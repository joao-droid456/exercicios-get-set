using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Retangulo
    {
        private double Base { get; set; }
        private double Altura { get; set; }

        public void CalcularArea(double bse, double altura)
        {
            Base = bse;
            Altura = altura;

            double calculo = Base * Altura;

            Console.WriteLine(calculo);
        }
    }
}