using System;

namespace Exercicios3_Estrutura_While
{
    class Program
    {
        //Método para ler uma senha e valida-la
        static void Exercicio1()
        {
            Console.WriteLine("Digite a senha:");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Digite a senha:");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }

        //Método para verificar em qual quadrante se encontra o ponto
        static void Exercicio2()
        {
            int x, y;
            string[] pontos;

            Console.WriteLine("Digite os pontos X e Y separados por espaço:");
            pontos = Console.ReadLine().Split(' ');

            x = int.Parse(pontos[0]);
            y = int.Parse(pontos[1]);

            if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Primeiro");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Segundo");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Terceiro");
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Quarto");
            }

        }

        //Método que contabiliza os votos de cada combustível
        static void Exercicio3()
        {
            int tipo = 0;
            int alcool = 0, gasolina = 0, diesel = 0;

            while (tipo != 4)
            {
                Console.WriteLine("Digite o tipo de combustivel preferido:");
                tipo = int.Parse(Console.ReadLine());

                if (tipo == 1)
                {
                    alcool++;
                }
                else if (tipo == 2)
                {
                    gasolina++;
                }
                else if (tipo == 3)
                {
                    diesel++;
                }
            }

            Console.WriteLine
            (
                "MUITO OBRIGADO\n"
                + "Alcool: {0}\n"
                + "Gasolina: {1}\n"
                + "Diesel: {2}"
                , alcool, gasolina, diesel
            );
        }

        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
        }
    }
}
