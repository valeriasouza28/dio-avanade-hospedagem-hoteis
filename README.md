Desafio de Projeto de Hospedagem
Este projeto consiste em um sistema de reserva de hospedagem, onde é possível cadastrar hóspedes, suítes e realizar reservas.

Funcionalidades
Cadastrar hóspedes
Cadastrar suítes
Realizar reserva de suíte para hóspedes
Tecnologias utilizadas
C#
.NET Core
Como utilizar
Clone este repositório:
bash
Copy code
git clone https://github.com/seu-usuario/nome-do-repositorio.git
Navegue até o diretório do projeto:
bash
Copy code
cd nome-do-repositorio
Compile e execute o projeto:
bash
Copy code
dotnet run
Exemplo de uso
csharp
Copy code
using System;
using System.Collections.Generic;
using DesafioProjetoHospedagem.Models.Reservas;
using DesafioProjetoHospedagem.Models.Suites;

class Program
{
    static void Main(string[] args)
    {
        // Cria os modelos de hóspedes e cadastra na lista de hóspedes
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "Hóspede 1");
        Pessoa p2 = new Pessoa(nome: "Hóspede 2");

        hospedes.Add(p1);
        hospedes.Add(p2);

        // Cria a suíte
        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        // Cria uma nova reserva, passando a suíte e os hóspedes
        Reserva reserva = new Reserva(diasReservados: 5);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        // Exibe a quantidade de hóspedes e o valor da diária
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
    }
}
Estrutura do projeto
O projeto está organizado da seguinte forma:

DesafioProjetoHospedagem.Models: Contém as classes modelo do sistema.
Program.cs: Arquivo principal que contém o código de exemplo de utilização do sistema.
