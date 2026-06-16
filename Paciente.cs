using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Paciente
    {
        private double _peso;
        private string? Nome { get; set; }
        private double Peso
        {
            get { return _peso; }
            set
            {
                if ( value <= 0)
                {
                    Console.WriteLine("O Peso não pode ser menor ou igual a zero.");
                    return;
                }
                _peso = value;
            }
        }
        public void Registrar(string nome, double peso)
        {
            Nome = nome;
            Peso = peso;
        }
        public void MostrarDado()
        {
            Console.WriteLine($"Nome: {Nome} | Peso: {_peso}");
        }
    }
}