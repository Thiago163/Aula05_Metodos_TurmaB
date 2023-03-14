using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_Metodos_TurmaB
{
    class ClasseB
    {
        // Métodos sem retorno e com paremetro

        // 01º Exemplo - método com 1 paramêtro (INT)

        public void soma(int b1)
        {
            int b2 = 100;
            int res_soma = b1 + b2;

            Console.WriteLine("O resultado da soma é " + res_soma);
        }

            // 02º Exemplo - método com 1 paramêtro (String)

            public void meu_nome(string nome)
            {
                Console.WriteLine("O meu nome é " + nome);
            }

        // 03º Exemplo - método com 2 ou + paramêtros (String e int)

        public void minha_idade(String nome, int idade)
        {
            Console.WriteLine(
                "O meu nome é: " + nome + "\n" +
                "Idade: " + idade); 
        }

        // 04º Exemplo - método com 2 ou + paramêtros

        public void cadastro_pessoa(
            string nome, string endereco, string telefone,
            string celular, string email, int idade_pessoa,
            string cpf, string rg, bool status_cadastro)
        {
            Console.WriteLine("Dados cadastrados\n\n");

            Console.WriteLine(
                "Nome" + nome + "\n" +
                "Endereco" + endereco + "\n" +
                "Telefone" + telefone + "\n" +
                "Celular" + celular + "\n" +
                "Email" + email + "\n" +
                "Idade" + idade_pessoa + "\n" +
                "CPF" + cpf + "\n" +
                "RG" + rg + "\n" +
                "Situação do cadastro" + status_cadastro.ToString()
                );
        }

    }
}
