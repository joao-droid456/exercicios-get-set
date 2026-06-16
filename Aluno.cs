using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Aluno
    {

        private double _nota;
        private string? Nome { get; set; }
        private int Matricula { get; set; }
        private double Nota
        {
            get
            {
                return _nota;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    Console.WriteLine("Nota Inválida");
                }
                else
                {
                    _nota = value;
                }
            }
        }

        public void DefinirNota(double nota)
        {
            Nota = nota;
        }
        public void MostrarNota()
        {

             if (_nota < 0 || _nota > 10)
    {
        return; 
    }

            Console.WriteLine(_nota);
        }
    }
}