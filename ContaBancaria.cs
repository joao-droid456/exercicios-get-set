using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class ContaBancaria
    {
        private int NumeroConta { get; set; }
        private double Saldo { get; set; }

         public void Depositar(double deposito)
        {
            Saldo += deposito;

            Console.WriteLine(Saldo);
        }
        public void Saque(double saque)
        {
            if (Saldo <= 0)
            {
                return;
            }
            Saldo -= saque;

            Console.WriteLine(Saldo);
        }
    }

}