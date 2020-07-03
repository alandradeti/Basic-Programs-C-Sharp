using System;
using System.Globalization;

namespace Overload_AutoProperties
{
    class Program
    {

        //Method that checks whether there will be an initial deposit
        private static char CheckInitialDeposit()
        {
            char initialDeposit;

            do
            {
                Console.Write("Will there be an initial deposit(y / n) ? ");
                initialDeposit = char.ToUpper(char.Parse(Console.ReadLine()));
            } while (!initialDeposit.Equals('Y') && !initialDeposit.Equals('N'));

            return initialDeposit;
        }

        //Method that performs the validation of the value, not allowing numbers less than or equal to 0
        private static double CheckValue(Boolean typeTransaction)
        {
            double value;
            do
            {
                if (typeTransaction == true)
                    Console.Write("Enter a deposit amount: ");
                else
                    Console.Write("Enter a withdrawal amount: ");

                value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            } while (value <= 0);

            return value;

        }

        static void Main(string[] args)
        {
            string number, owner;

            BankAccount account;

            Console.Write("Enter the account number: ");
            number = Console.ReadLine();
            Console.Write("Enter the owner of the account: ");
            owner = Console.ReadLine();

            if (CheckInitialDeposit().Equals('Y'))
            {
                account = new BankAccount(number, owner, CheckValue(true));
            }
            else
            {
                account = new BankAccount(number, owner);
            }

            Console.WriteLine("\nAccount Information:");
            Console.WriteLine(account);

            account.MakeDeposit(CheckValue(true));
            Console.WriteLine("Account data updated: ");
            Console.WriteLine(account);

            account.CashOut(CheckValue(false));
            Console.WriteLine("Account details updated: ");
            Console.WriteLine(account);

        }

        
    }
}
