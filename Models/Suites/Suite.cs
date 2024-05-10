using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models.Suites
{
    public class Suite
    {
        public Suite() { }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
        public int NumeroSuite { get; set; }
        public StatusSuite Status { get; set; } = StatusSuite.Disponivel;
        public Hotel hotel { get; set; } = new Hotel();
        // Suite suite;

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria, int numeroSuite)
        {
            if (string.IsNullOrWhiteSpace(tipoSuite))
            {
                throw new ArgumentException("O tipo da suíte não pode estar em branco.");
            }

            if (capacidade <= 0)
            {
                throw new ArgumentException("A capacidade da suíte deve ser maior que zero.");
            }

            if (valorDiaria <= 0)
            {
                throw new ArgumentException("O valor da diária deve ser maior que zero.");
            }

            if (numeroSuite <= 0)
            {
                throw new ArgumentException("O número da suíte deve ser maior que zero.");
            }



            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
            NumeroSuite = numeroSuite;
            Status = StatusSuite.Disponivel;
        }

        public bool VerificaDisponibilidadeDaSuite()
        {
            return Status == StatusSuite.Disponivel;
        }

        public void MarcarComoOcupada()
        {
            Status = StatusSuite.Ocupada;
        }

        public void MarcarComoDisponivel()
        {
            Status = StatusSuite.Disponivel;
        }


        public void ToString()
        {
            Console.WriteLine($"Nome: {TipoSuite}, Capacidade: {Capacidade}, Preço: R${ValorDiaria}, Número: {NumeroSuite}, Status: {Status}");
        }
    }
}
