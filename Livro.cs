using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Livro
    {
        private int _numerodepaginas;
        private string? Autor { get; set; }
        private string? Titulo { get; set; }
        private int NumeroDePaginas
        {
            get
            {
                return _numerodepaginas;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Numero de páginas não válido");
                }
                else
                {
                    _numerodepaginas = value;
                }
            }
        }
        public void Definir(string nome, string titulo, int numero)
        {
            Autor = nome;
            Titulo = titulo;
            NumeroDePaginas = numero;
        }
       public void Exibir()
        {
            Console.WriteLine($"Nome: {Autor} | Titulo: {Titulo} | Numero de Páginas: {_numerodepaginas}");
        }
    }
}