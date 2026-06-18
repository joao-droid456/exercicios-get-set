using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Funcionarios
    {
        private string? Nome { get; set; }
        private double Salario { get; set; }

        public void Registrar(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public double ObterSalario()
        {
            return Salario;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome} | Salário: {Salario}");
        }
    }

    public class Empresa
    {
        private string? Nome { get; set; }

        private List<Funcionarios> funcionarios = new();

        public void RegistrarEmpresa(string nome)
        {
            Nome = nome;
        }

        public void AdicionarFuncionario(Funcionarios funcionario)
        {
            funcionarios.Add(funcionario);
        }

       
        public double FolhaPagamentoTotal
        {
            get
            {
                double total = 0;

                foreach (Funcionarios funcionario in funcionarios)
                {
                    total += funcionario.ObterSalario();
                }

                return total;
            }
        }

        public void MostrarFuncionarios()
        {
            foreach (Funcionarios funcionario in funcionarios)
            {
                funcionario.MostrarDados();
            }
        }
    }
}