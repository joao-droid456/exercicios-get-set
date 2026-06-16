using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Data
    {
        private int _dia;
        private int _mes;
        private int _ano;
        private int Dia
        {
            get
            {
                return _dia;
            }
            set
            {
                if (value <= 0 || value > 31)
                {
                    Console.WriteLine("Não existe esse dia em qualquer mês");
                    return;
                }
                else
                {
                    _dia = value;
                }
            }
        }
        private int Mes
        {
            get
            {
                return _mes;
            }
            set
            {
                if ((value == 4 || value == 6 || value == 9 || value == 11) && _dia > 30)
                {
                    Console.WriteLine("Esse mês possui apenas 30 dias");
                    return;
                }
                else if (value == 2 && _dia > 29)
                {
                    Console.WriteLine("Fevereiro não tem mais de 29 ou 28 dias");
                    return;
                }
                _mes = value;
            }
        }
        private int Ano
        {
            get
            {
                return _ano;
            }
            set
            {
                if (_mes == 2 && _dia == 29 && value % 4 != 0)
                {
                    Console.WriteLine("Esse ano não é bissexto");
                    return;
                }
                else
                {
                    _ano = value;
                }
            }
        }

        public void DefinirDia(int dia)
        {
            Dia = dia;
        }
        public void DefinirMes(int mes)
        {
            Mes = mes;
        }
        public void DefinirAno(int ano)
        {
            Ano = ano;
        }
        public void MostrarDados()
        {
            Console.WriteLine($"Dia: {_dia} \n Mês: {_mes} \n Ano: {_ano}");
        }
    }
}