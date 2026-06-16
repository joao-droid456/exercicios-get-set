using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Produto
    {

        private double _preco;
        private string? Nome { get; set; }
        private double Preco
        {
            get
            {
                return _preco;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Preço inválido");
                }
                else
                {
                    _preco = value;
                }
            }
        }
        private int Quantidade { get; set; }

        public void CadastrarProduto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public void MostrarProduto()
        {

          Console.WriteLine($"Nome: {Nome} | Preço: {_preco} | Quantidade: {Quantidade}");
        }
    }
}