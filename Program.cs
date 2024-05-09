using System.ComponentModel;
using System.Text;
using DesafioProjetoHospedagem.Models;
using DesafioProjetoHospedagem.Models.Reservas;
using DesafioProjetoHospedagem.Models.Suites;


Console.OutputEncoding = Encoding.UTF8;

ListaReservas listaReservas = new ListaReservas();

//cria hotel
Hotel hotel = new Hotel("Coders Dotnet", 100);

//criamos as suites 

Suite suite1 = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 50, numeroSuite: 1);
Suite suite2 = new Suite(tipoSuite: "Luxo", capacidade: 2, valorDiaria: 80, numeroSuite: 2);
Suite suite3 = new Suite(tipoSuite: "Comum", capacidade: 2, valorDiaria: 30, numeroSuite: 3);

//cadastramos as suites 
suite1.CadastrarSuite();
suite2.CadastrarSuite();
suite3.CadastrarSuite();

//criamos um possível hospede
Pessoa hospede1 = new Pessoa("Valéria", "Souza", 1);
Pessoa hospede2 = new Pessoa("Sr", "S", 1);


Reserva reservaHospede1 = new Reserva(hospede1, 5, suite1, listaReservas);
Reserva reservaHospede2 = new Reserva(hospede2, 5, suite2, listaReservas);

reservaHospede1.ConfirmarReserva();
reservaHospede2.ConfirmarReserva();

listaReservas.AdicionaListaReservas(reservaHospede1);
listaReservas.AdicionaListaReservas(reservaHospede2);

listaReservas.ExibirListaDeReservas();

reservaHospede1.CancelarReserva();

