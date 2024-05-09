using System;

namespace DesafioProjetoHospedagem.Models
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome, string sobrenome, int qtdPessoa)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome não pode estar em branco ou ser nulo.", nameof(nome));
            }

            if (string.IsNullOrWhiteSpace(sobrenome))
            {
                throw new ArgumentException("O sobrenome não pode estar em branco ou ser nulo.", nameof(sobrenome));
            }

            if (qtdPessoa <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(qtdPessoa), "A quantidade de pessoas deve ser maior que zero.");
            }

            Nome = nome;
            Sobrenome = sobrenome;
            QtdPessoa = qtdPessoa;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int QtdPessoa { get; set; } // Corrigido o nome da propriedade

        public void ObterDados()
        {
            Console.WriteLine($"Hóspede: {NomeCompleto}, Quantidade de Hóspedes: {QtdPessoa}");
        }
    }
}
