using System;
using DesafioProjetoHospedagem.Models.Reserva;
using DesafioProjetoHospedagem.Models.Suites;

namespace DesafioProjetoHospedagem.Models.Reservas
{
    public class Reserva
    {
        public Suite Suite { get; set; } = new Suite();
        public int DiasReservados { get; set; }
        public StatusReserva Status { get; set; } = StatusReserva.Pendente;
        public Pessoa Hospede { get; set; } = new Pessoa();



        public Reserva() { }

        // Método para criar uma reserva
        public Reserva(Pessoa hospede, int diasReservados, Suite suite)
        {
            if (hospede == null)
            {
                throw new ArgumentNullException(nameof(hospede), "O hóspede não pode ser nulo.");
            }

            if (diasReservados <= 0)
            {
                throw new ArgumentException("O número de dias reservados deve ser maior que zero.");
            }

            if (suite == null)
            {
                throw new ArgumentNullException(nameof(suite), "A suíte não pode ser nula.");
            }

            Hospede = hospede;
            DiasReservados = diasReservados;
            Suite = suite;
            Status = StatusReserva.Pendente;
            // ListaReservas.AdicionaListaReservas(this);

        }

        // Método para verificar se a reserva pode ser confirmada
        public bool PodeConfirmarReserva()
        {
            if (Suite == null)
            {
                throw new InvalidOperationException("A suíte associada à reserva não pode ser nula.");
            }

            if (Hospede == null)
            {
                throw new InvalidOperationException("O hóspede associado à reserva não pode ser nulo.");
            }

            return Suite.VerificaDisponibilidadeDaSuite() && Hospede.QtdPessoa <= Suite.Capacidade;
        }

        // Método para confirmar a reserva
        public void ConfirmarReserva(Reserva reserva)
        {
            if (PodeConfirmarReserva())
            {
                Status = StatusReserva.Confirmada;
                Suite.MarcarComoOcupada();
                decimal valorTotal = CalcularValorTotal();
                Console.WriteLine($"=====\nReserva confirmada! Valor total: {valorTotal:C}\n===== ");
            }
            else
            {
                throw new InvalidOperationException("A reserva não pode ser confirmada devido à falta de disponibilidade ou capacidade da suíte.");
            }
        }

        // Método para cancelar a reserva
        public void CancelarReserva()
        {
            Reserva reserva = new Reserva();

            Status = StatusReserva.Cancelada;
            Suite.MarcarComoDisponivel();
        }



        // Método para calcular o valor total da reserva
        private decimal CalcularValorTotal()
        {
            decimal valorDiaria = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                valorDiaria *= 0.9m; // Aplica desconto de 10% para reservas com 10 dias ou mais
            }
            return valorDiaria;
        }

        public decimal ObterValorDiaria()
        {
            return CalcularValorTotal();
        }

        public void ObterDados()
        {
            decimal ValorTotal = CalcularValorTotal();
            Console.WriteLine($"Dias Reservados: {DiasReservados}, Status da Reserva: {Status}, Valor Total: {ValorTotal}");
        }

        public void ObterDadosCompletos()
        {
            Hospede.ObterDados();
            Suite.ToString();
            ObterDados();

        }
    }
}

