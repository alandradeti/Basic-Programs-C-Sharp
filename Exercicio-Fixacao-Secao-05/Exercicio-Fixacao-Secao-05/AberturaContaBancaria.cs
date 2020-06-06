using System;
using System.Globalization;

namespace Exercicio_Fixacao_Secao_05
{
    class AberturaContaBancaria
    {
        static void Main(string[] args)
        {
            string Numero, Titular;

            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            Numero = Console.ReadLine();
            Console.Write("Entre com o titular da conta: ");
            Titular = Console.ReadLine();

            if (VerificarDepositoInicial().Equals('S'))
            {
                conta = new ContaBancaria(Numero, Titular, VerificarValor(true));
            }
            else
            {
                conta = new ContaBancaria(Numero, Titular);
            }

            Console.WriteLine("\nDados da Conta:");
            Console.WriteLine(conta);

            conta.RealizarDeposito(VerificarValor(true));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            conta.RealizarSaque(VerificarValor(false));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }

        //Método que verifica se irá haver depósito inicial
        private static char VerificarDepositoInicial()
        {
            char depositoInicial;

            do
            {
                Console.Write("Haverá depósito inicial (s/n) ? ");
                depositoInicial = char.ToUpper(char.Parse(Console.ReadLine()));
            } while (!depositoInicial.Equals('S') && !depositoInicial.Equals('N'));
            
            return depositoInicial;
        }

        //Método que realiza a validação do valor não permitindo números menores ou iguais 0
        private static double VerificarValor(Boolean tipoTransacao)
        {
            double valor;
            do
            {
                if (tipoTransacao == true) 
                    Console.Write("Entre com um valor para depósito: ");
                else 
                    Console.Write("Entre com um valor para saque: ");

                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            } while (valor <= 0);

            return valor;

        }
    }
}
