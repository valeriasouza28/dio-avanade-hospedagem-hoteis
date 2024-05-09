using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models.Suites
{
    public class Suite
    {
        public Suite() { }

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

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
        public int NumeroSuite { get; set; }
        public StatusSuite Status { get; set; } = StatusSuite.Disponivel;
        public List<Suite> Suites { get; set; } = new List<Suite>();
        public Hotel Hotel { get; set; }

        public void CadastrarSuite()
        {
            Suite suite = new Suite();
            if (suite == null)
            {
                throw new ArgumentNullException(nameof(suite), "A suíte fornecida para cadastro não pode ser nula.");
            }

            if (Suites.Contains(suite))
            {
                throw new InvalidOperationException("A suíte já está cadastrada.");
            }

            if (Suites.Count >= Hotel.QtdSuites)
            {
                throw new InvalidOperationException("Todas as suítes já estão cadastradas. Consulte o hotel para a quantidade de suítes disponíveis.");
            }

            Suites.Add(suite);
        }

        public void RemoverSuite(Suite suite)
        {
            if (suite == null)
            {
                throw new ArgumentNullException(nameof(suite), "A suíte fornecida para remoção não pode ser nula.");
            }

            if (!Suites.Contains(suite))
            {
                throw new InvalidOperationException("A suíte não está cadastrada e não pode ser removida.");
            }

            Suites.Remove(suite);
        }

        public void ListarSuites(List<Suite> suites)
        {
            foreach (var s in suites)
            {
                Console.WriteLine(s);
            }
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

        public override string ToString()
        {
            return $"Nome: {TipoSuite}, Capacidade: {Capacidade}, Preço: R${ValorDiaria}, Número: {NumeroSuite}, Status: {Status}";
        }
    }
}
