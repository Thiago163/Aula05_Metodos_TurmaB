using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_Metodos_TurmaB
{
    class ClasseA
    {
        static void Main(string[] args)
        {
            ClasseB cb = new ClasseB();

            cb.soma(200);

            int k1 = 40;
            cb.soma(k1);

            Console.ReadKey();
            Console.Clear();

            // Chamada do 02º método (String)
            cb.meu_nome("Joana da Silva");

            string n = "Ricardo Medeiros";
            cb.meu_nome(n);

            Console.ReadKey(); Console.Clear();

            // Chamada do 03º método (String e int)

            cb.minha_idade("Ana Silva", 20);

            string nome_escolhido = "Thiago Miranda";
            int idade = 25;
            cb.minha_idade(nome_escolhido, idade);

            Console.ReadKey(); Console.Clear();

            Console.ReadLine();

            // Chamada do 04º método (com entrada de dados)

            Console.Write("Digite o nome: ");
            String nome = Console.ReadLine();

            Console.Write("Digite o endereço: ");
            String endereco = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            String telefone = Console.ReadLine();

            Console.Write("Digite o celular: ");
            String celular = Console.ReadLine();

            Console.Write("Digite o email: ");
            String email = Console.ReadLine();

            Console.Write("Digite o idade: ");
            int idade_pessoa = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o cpf: ");
            String cpf = Console.ReadLine();

            Console.Write("Digite o rg: ");
            String rg = Console.ReadLine();

            Console.Write("Digite o situação cadastro: ");
            String status_cadastro = Console.ReadLine();
        }
    }
}
