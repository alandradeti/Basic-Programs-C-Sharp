using System;
using System.Globalization;

namespace AutoProperties_Overhead
{
    class BankAccount
    {

        //Declaration of attributes using "Auto Properties"
        public string AccountNumber { get; private set; }
        public string NameOwner { get;  set; }
        public double Balance { get; private set; }


        //Builder without the need to inform the initial deposit
        public BankAccount(string accountNumber, string nameOwner)
        {
            AccountNumber = accountNumber;
            NameOwner = nameOwner;
        }

        //Builder that receives the same characteristics as the builder above and needs the initial deposit
        public BankAccount(string accountNumber, string nameOwner, double initialDeposit) : this(accountNumber, nameOwner)
        {
            MakeDeposit(initialDeposit);
        }

        //Method that makes the deposit in the account
        public void MakeDeposit(double valueDeposit) 
        {

            Balance += valueDeposit;
        }

        // Method for withdrawing from the account
        public void CashOut(double valueRedraw) 
        {
            Balance -= valueRedraw + 5.00;
        }

        //Overloaded method to display account data
        public override string ToString()
        {
            return "Account: " + AccountNumber + ", "
            + "Owner: " + NameOwner + ", "
            + "Balance: $ " + Balance.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }

    }
}
