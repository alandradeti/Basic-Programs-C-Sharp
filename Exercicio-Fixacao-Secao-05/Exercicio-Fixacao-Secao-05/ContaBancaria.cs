using System;
using System.Globalization;

namespace Exercicio_Fixacao_Secao_05
{
    class ContaBancaria
    {
        
        private string _numeroConta;
        private string _nomeTitular;

        //Declaração de atributo utilizando "Auto Propertie"
        public double SaldoConta { get; set; }


        //Construtor sem necessidade de informar o deposito inicial
        public ContaBancaria(string numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        //Construtor que recebe as mesmas características do construtor acima e necessita do deposito inicial
        public ContaBancaria(string numeroConta, string nomeTitular, double saldoConta) : this(numeroConta, nomeTitular)
        {
            SaldoConta = saldoConta;
        }

        //Properties customizadas com verificação se está vazio
        public string NumeroConta
        {
            get { return _numeroConta; }
            set
            {
                if (value != null && value.Trim().Length > 0) _numeroConta = value;
            }
        }

        public string NomeTitular
        {
            get { return _nomeTitular; }
            set
            {
                if (value != null && value.Trim().Length > 0) _nomeTitular = value;
            }
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
