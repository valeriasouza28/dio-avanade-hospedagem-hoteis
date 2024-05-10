using System.Reflection.Metadata;
using System.Diagnostics;
using System.ComponentModel;
using System.Text;
using DesafioProjetoHospedagem.Models;
using DesafioProjetoHospedagem.Models.Reservas;
using DesafioProjetoHospedagem.Models.Suites;
using System.Reflection;

static void AdicionaListaReservas(List<Reserva> Reservas, Reserva reserva)
{
  Reservas.Add(reserva);
}

static void RemoveListaReservas(List<Reserva> Reservas, Reserva reserva)
{
  Reservas.Remove(reserva);
}

static void ExibirListaDeReservas(List<Reserva> Reservas)
{
  Console.WriteLine($"===== Listando Resrvas =====");
  foreach (var r in Reservas)
  {
    r.ObterDadosCompletos();
  }
  Console.WriteLine(" ===== ===== ===== ===== ");

}

Console.OutputEncoding = Encoding.UTF8;
Hotel hotel = new Hotel("Coders Dotnet", 4);
List<Reserva> Reservas = new List<Reserva>();

Pessoa pessoa1 = new Pessoa("Maria", "souza", 1);
Suite suite = new Suite("premium", 2, 50, 1);
Reserva res1 = new Reserva(pessoa1, 5, suite);
Pessoa pessoa2 = new Pessoa("Valéria", "souza", 1);
Suite suite2 = new Suite("luxo", 2, 50, 1);
Reserva res2 = new Reserva(pessoa2, 5, suite2);

res1.ConfirmarReserva(res1);
AdicionaListaReservas(Reservas, res1);

res2.ConfirmarReserva(res2);
AdicionaListaReservas(Reservas, res2);
ExibirListaDeReservas(Reservas);

RemoveListaReservas(Reservas, res1);
ExibirListaDeReservas(Reservas);

