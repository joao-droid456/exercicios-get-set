using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Imovel
    {
        private string? Endereco { get; set; }
        private double Valor { get; set; }

        public void aplicarDesconto(string nome, double valorImovel, double valor)
        {
            Endereco = nome;
            Valor = valorImovel;

            double desconto = Valor * (valor / 100);
            double precoFinal = Valor - desconto;

            Console.WriteLine(precoFinal);
        }
    }
}