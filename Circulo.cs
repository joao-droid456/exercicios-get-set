using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Circulo
    {
        private double _raio;
        private double Diametro
        {
            get
            {
                return _raio * 2;
            }
        }
        private double Area { get
            {
                return (_raio * _raio) * 3.14159;
            }
        }
        public void DefinirRaio(double raio)
        {
            _raio = raio;

        }
        public void MostrarDado()
        {
            Console.WriteLine($"Raio: {_raio} \n Diametro: {Diametro} \n Area: {Area}");
        }
    }
}