using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Funcionario
    {

        private double _salaro;
        private string? Nome { get; set; }
        private double Salario 
        {
            get
            {
                return _salaro;
            }
            set
            {
                if (value < _salaro )
                {
                    Console.WriteLine("Não é permitido reduzir salários");
                }
                else
                {
                    _salaro = value;
                }
            }
        }
        public void Reajuste(double salarioNovo)
        {
            Salario = salarioNovo;
        }
        public void MostrarSalario()
        {
            Console.WriteLine(_salaro);
        }
    }
}