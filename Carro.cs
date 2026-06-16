using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Carro
    {
        private int _ano;
        private string? Marca { get; set; }
        private string? Modelo { get; set; }
        private int Ano
        {
            get
            {
                return _ano;
            }
            set
            {
                if (value < 1886)
                {
                    Console.WriteLine("Não existem carros antes desta data");
                }
                else
                {
                    _ano = value;
                }
            }
        }
        public void Cadastrar(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;

            Console.WriteLine($"Marca: {Marca} | Modelo: {Modelo} | Ano: {_ano}");
        }
    }
}