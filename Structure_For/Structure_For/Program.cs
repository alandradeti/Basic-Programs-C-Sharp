using System;
using System.Globalization;

namespace Structure_For
{
    class Program
    {
        //Method that shows the unpaired numbers of the typed N
        static void CheckUnpairedInterval()
        {
            int number = 0;
            Console.WriteLine("Enter an integer from 1 to 1000:");
            number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 1000)
            {
                for (int i = 0; i <= number; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("The value entered is invalid!");
            }

        }

        //Method that shows which numbers are within the range 10 to 20 including the extremes
        static void NumbersInRange()
        {
            int numberValues, value = 0;
            int withinRange = 0, outRange = 0;

            Console.WriteLine("Enter the number of values:");
            numberValues = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberValues; i++)
            {
                Console.WriteLine("Enter the {0} th value:", i + 1);
                value = int.Parse(Console.ReadLine());

                if (value >= 10 && value <= 20)
                {
                    withinRange++;
                }
                else
                {
                    outRange++;
                }
            }

            Console.WriteLine
            (
                "{0} in\n"
                + "{1} out"
                , withinRange, outRange
            );
        }

        //Method that performs the weighted average of N tests
        static void CalculateAverageWeighted()
        {
            int numberTests;
            double weightedAverage;
            double a = 0, b = 0, c = 0;
            

            Console.WriteLine("Enter the number of tests: ");
            numberTests = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberTests; i++)
            {
                string[] tests = Console.ReadLine().Split(' ');

                a = double.Parse(tests[0], CultureInfo.InvariantCulture);
                b = double.Parse(tests[1], CultureInfo.InvariantCulture);
                c = double.Parse(tests[2], CultureInfo.InvariantCulture);

                weightedAverage = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(weightedAverage.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        //Method that performs the division of N pairs
        static void CalculateDivisionTwoNumbers()
        {
            int qtyPairs, firstNumber, secondNumber, resultDivision;

            Console.WriteLine("Enter the number of pairs: ");
            qtyPairs = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtyPairs; i++)
            {
                string[] pairs = Console.ReadLine().Split(' ');

                firstNumber = int.Parse(pairs[0], CultureInfo.InvariantCulture);
                secondNumber = int.Parse(pairs[1], CultureInfo.InvariantCulture);

                if (secondNumber == 0)
                {
                    Console.WriteLine("Division Impossible");
                }
                else
                {
                    resultDivision = firstNumber / secondNumber;
                    Console.WriteLine(resultDivision.ToString("F1", CultureInfo.InvariantCulture));
                }

            }

        }

        //Method that performs the factorial
        static void CalculateFactorial()
        {
            int number = 0, factorial = 0;

            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                factorial = number;
                for (int i = 1; i < number; i++)
                {
                    factorial *= (number - i);
                }
            }
            else
            {
                factorial = 1;
            }

            Console.WriteLine(factorial);

        }

        // Method that shows all divisors of a number N
        static void CalculateNumberDividers()
        {
            int number;

            Console.WriteLine("Enter an integer:");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Method that shows the line number, then the square and the value cube
        static void CalculateNumberSquareCube() 
        {
            int number;

            Console.WriteLine("Enter an integer: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++) {
                Console.WriteLine(i + " " + Math.Pow(i,2) + " " + Math.Pow(i,3));
            }
        }

        static void Main(string[] args)
        {

            int menuOption;

            Console.WriteLine
            ("Choose the option you want: "

                + "\n1 - Check the unpaired ones that are in the range of a number."

                + "\n2 - Check how many numbers are in the range and out of range."

                + "\n3 - Perform the weighted average calculation."

                + "\n4 - Calculate the division of two numbers."

                + "\n5 - Perform the factorial calculation of a number."

                + "\n6 - Show all divisors of a number."

                + "\n7 - Calculate the square and cube of all numbers that are in the range of a number."

            );

            //If there is no option in the menu, the program will be closed
            menuOption = int.Parse(Console.ReadLine());
            switch (menuOption)
            {
                case 1:
                    CheckUnpairedInterval();
                    break;
                case 2:
                    NumbersInRange();
                    break;
                case 3:
                    CalculateAverageWeighted();
                    break;
                case 4:
                    CalculateDivisionTwoNumbers();
                    break;
                case 5:
                    CalculateFactorial();
                    break;
                case 6:
                    CalculateNumberDividers();
                    break;
                case 7:
                    CalculateNumberSquareCube();
                    break;
                default:
                    break;
            }

        }
    }
}
