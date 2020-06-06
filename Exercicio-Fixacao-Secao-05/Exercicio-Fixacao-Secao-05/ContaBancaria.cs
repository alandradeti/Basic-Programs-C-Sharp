using System;
using System.Globalization;

namespace Exercicio_Fixacao_Secao_05
{
    class ContaBancaria
    {

        //Declaração de atributos utilizando "Auto Properties"
        public string NumeroConta { get; private set; }
        public string NomeTitular { get;  set; }
        public double SaldoConta { get; private set; }


        //Construtor sem necessidade de informar o deposito inicial
        public ContaBancaria(string numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        //Construtor que recebe as mesmas características do construtor acima e necessita do deposito inicial
        public ContaBancaria(string numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
        {
            RealizarDeposito(depositoInicial);
        }

        //Método que realiza o deposito na conta
        public void RealizarDeposito(double valorDeposito) 
        {
            SaldoConta += valorDeposito;
        }

        //Método que realiza o saque na conta
        public void RealizarSaque(double valorSaque) 
        {
            SaldoConta -= valorSaque + 5.00;
        }

        //Método com sobrecarga para mostrar os dados da conta
        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", "
            + "Titular: " + NomeTitular + ", "
            + "Saldo: $ " + SaldoConta.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }

    }
}
