using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
   public class Contato
    {
        private string? Nome { get; set; }
        private int Telefone { get; set; }

        public void Registrar(string nome, int telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome} | Telefone: {Telefone}");
        }
    }

    public class Agenda
    {
        private Contato _contato = new Contato();

        private Contato Contato
        {
            get
            {
                return _contato;
            }
            set
            {
                _contato = value;
            }
        }

        public void Registrar(string nome, int telefone)
        {
            Contato.Registrar(nome, telefone);
        }

        public void MostrarDados()
        {
            Contato.MostrarDados();
        }
    }
}