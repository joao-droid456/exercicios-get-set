using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Triangulo
    {
        private int _ladoA;
        private int _ladoB;
        private int _ladoC;

        private int LadoA
        {
            get { return _ladoA; }
            set
            {
                if (_ladoB == 0 || _ladoC == 0)
                {
                    _ladoA = value;
                    return;
                }

                if (value + _ladoB > _ladoC && value + _ladoC > _ladoB && _ladoB + _ladoC > value)
                {
                    _ladoA = value;
                }
                else
                {
                    Console.WriteLine("Esses Valores não formam um triangulo válido.");
                }
            }
        }
        private int LadoB
        {
            get { return _ladoB; }
            set
            {
                if (_ladoA == 0 || _ladoC == 0)
                {
                    _ladoB = value;
                    return;
                }

                if (_ladoA + value > _ladoC && _ladoA + _ladoC > value && value + _ladoC > _ladoA)
                {
                    _ladoB = value;
                }
                else
                {
                    Console.WriteLine("Esses Valores não formam um triangulo válido.");
                }
            }
        }
        private int LadoC
        {
            get { return _ladoC; }
            set
            {
                if (_ladoB == 0 || _ladoA == 0)
                {
                    _ladoC = value;
                    return;
                }

                if (_ladoA + _ladoB > value && _ladoA + value > _ladoB && _ladoB + value > _ladoA)
                {
                    _ladoC = value;
                }
                else
                {
                    Console.WriteLine("Esses Valores não formam um triangulo válido.");
                }
            }
        }
        public void CriarLados(int a, int b, int c)
        {
            LadoA = a;
            LadoB = b;
            LadoC = c;
        }
        public void MostrarDados()
        {
            Console.WriteLine($"Lado A: {LadoA} \n Lado B: {LadoB} \n Lado C: {LadoC}");
        }
    }
}