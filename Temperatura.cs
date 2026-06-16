using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Temperatura
    {
        private double _celsius;
        private double Fahrenheit
        {
            get
            {
                return _celsius * 9.0 / 5.0 + 32;
            }
        }
        public void definirCelsius(double celsius)
        {
            _celsius = celsius;
        }
        public void MostrarFahrenheit()
        {
            Console.WriteLine(Fahrenheit);
        }
    }
}