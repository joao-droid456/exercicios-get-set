using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_15_06
{
    public class Voo
    {

        private string? _origem;
        private string? _destino;
        private int NumeroVoo { get; set; }
        private string? Origem
        {
            get { return _origem; }
            set
            {
                if (Destino != null &&
                    value != null &&
                    value.ToLower() == Destino.ToLower())
                {
                    Console.WriteLine("Destino não pode ser igual à origem.");
                    return;
                }

                _origem = value;
            }
        }
        private string? Destino
        {
            get { return _destino; }
            set
            {
                if (Origem != null &&
                    value != null &&
                    value.ToLower() == Origem.ToLower())
                {
                    Console.WriteLine("Destino não pode ser igual à origem.");
                    return;
                }

                _destino = value;
            }
        }

        public void RegistrarPontos(string origem, string destino)
        {
           
            Origem = origem;
            Destino = destino;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Origem: {_origem} | Destino: {_destino}");
        }
    }
}