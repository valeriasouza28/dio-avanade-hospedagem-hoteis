using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models.Reservas
{
  public class ListaReservas
  {
    private List<Reserva> Reservas = new List<Reserva>();

    public void AdicionaListaReservas(Reserva reserva)
    {
      if (reserva == null)
      {
        throw new ArgumentNullException(nameof(reserva), "A reserva não pode ser nula.");
      }

      Reservas.Add(reserva);
    }

    public void RemoveListaReservas(Reserva reserva)
    {
      if (reserva == null)
      {
        throw new ArgumentNullException(nameof(reserva), "A reserva não pode ser nula.");
      }

      if (!Reservas.Contains(reserva))
      {
        throw new InvalidOperationException("A reserva especificada não está na lista de reservas.");
      }

      Reservas.Remove(reserva);
    }

    public void ExibirListaDeReservas()
    {
      foreach (var r in Reservas)
      {
        r.ObterDadosCompletos();
      }
    }
  }
}
