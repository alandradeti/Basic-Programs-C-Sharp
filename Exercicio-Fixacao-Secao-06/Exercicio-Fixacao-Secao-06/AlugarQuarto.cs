using System;

namespace Exercicio_Fixacao_Secao_06
{
    class AlugarQuartos
    {
        static void Main(string[] args)
        {
            Estudante[] estudante = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int quantidadeQuarto = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeQuarto; i++)
            {
                Console.WriteLine($"\nAluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                //Criando o objeto estudante com os dados recebidos
                estudante[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (estudante[i] != null)
                {
                    Console.WriteLine(i + ": " + estudante[i]);
                }
            }
        }   
    }
}
