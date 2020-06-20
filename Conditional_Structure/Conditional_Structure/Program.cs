using System;
using System.Globalization;

namespace Conditional_Structure
{
    class Program
    {
        //Method to check whether the number is positive or negative
        static void IsPositive()
        {
            int number;

            Console.WriteLine("Enter an integer:");
            number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("NEGATIVE");
            }
            else
            {
                Console.WriteLine("POSITIVE");
            }
        }

        //Method to check whether the number is PAIR or UNPAIRED
        static void IsPair()
        {
            int number;

            Console.WriteLine("Enter an integer: ");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("PAIR");
            }
            else
            {
                Console.WriteLine("UNPAIRED");
            }
        }

        //Method to check if the number is multiple of the other
        static void IsMultiple() 
        {
            int a, b;
            string[] numbers;

            Console.WriteLine("Enter the value of A and B separated by space: ");
            numbers = Console.ReadLine().Split(' ');
            
            a = int.Parse(numbers[0]);
            b = int.Parse(numbers[1]);

            if ((a % b) == 0 || (b % a) == 0)
            {
                Console.WriteLine("Are Multiple");
            }
            else
            {
                Console.WriteLine("Not Multiple");
            }

        }

        //Method to check the number of hours spent playing
        static void GameDuration() 
        {
            int finalHour, startHour,duration;
            string[] hours;

            Console.WriteLine("Enter the start time and end time of the game separated by space: ");
            hours = Console.ReadLine().Split(' ');

            startHour = int.Parse(hours[0]);
            finalHour = int.Parse(hours[1]);

            if (startHour < finalHour) 
            {
                duration = finalHour - startHour;
                Console.WriteLine("THE GAME LASTED {0} TIME (S)", duration);
            }
            else
            {
                duration = 24 - startHour + finalHour;
                Console.WriteLine("THE GAME LASTED {0} TIME(S)", duration);
            }

        }

        //Method to check the total price of a product
        static void PurchaseProduct() 
        {
            int code, quantity;
            string[] product;

            Console.WriteLine("Enter the product code and quantity separated by space: ");
            product = Console.ReadLine().Split(' ');


            code = int.Parse(product[0]);
            quantity = int.Parse(product[1]);

            if (code == 1) {
                Console.WriteLine("Total: R$ " + (quantity * 4.00f).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (code == 2)
            {
                Console.WriteLine("Total: R$ " + (quantity * 4.50f).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (code == 3)
            {
                Console.WriteLine("Total: R$ " + (quantity * 5.00f).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (code == 4)
            {
                Console.WriteLine("Total: R$ " + (quantity * 2.00f).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (code == 5)
            {
                Console.WriteLine("Total: R$ " + (quantity * 1.50f).ToString("F2", CultureInfo.InvariantCulture));
            }

        }

        //Method to check which range the number is in
        static void NumberInterval() 
        {
            float number;

            Console.WriteLine("Enter a value: ");
            number = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (number <= 25.00) 
            {
                Console.WriteLine("Range (0.25)");
            }
            else if (number <= 50.00)
            {
                Console.WriteLine("Range (25,50)");
            }
            else if (number <= 75.00)
            {
                Console.WriteLine("Range (50,75)");
            }
            else if (number <= 100.00)
            {
                Console.WriteLine("Range (75,100)");
            }
            else if (number < 0.00 || number > 100.00)
            {
                Console.WriteLine("Out of range");
            }
        }

        //Method to check which quadrant the coordinates are in
        static void QuadrantCoordinate() 
        {
            float x, y;
            string[] coordinate;

            Console.WriteLine("Enter the value of X and Y separated by space");
            coordinate = Console.ReadLine().Split(' ');

            x = float.Parse(coordinate[0], CultureInfo.InvariantCulture);
            y = float.Parse(coordinate[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origin");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Quadrant 1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Quadrant 2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Quadrant 3");
            } 
            else if (x > 0.0 && y < 0.0) 
            {
                Console.WriteLine("Quadrant 4");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Y axis");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("X axis");
            }
        }

        //Method to verify the amount of income tax based on salary
        static void TaxAmount()
        {
            double salary, tax = 0;

            Console.WriteLine("Enter salary: ");
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salary <= 2000.00)
            {
                tax = 0.00;
            }
            else if (salary <= 3000.00)
            {
                tax = (salary - 2000.00) * 0.08;
            }
            else if (salary <= 4500.00)
            {
                tax = (salary - 3000.00) * 0.18 + 1000.00 * 0.08;
            }
            else if (salary > 4500.00) {
                tax = (salary - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
            }

            if (tax == 0.0)
            {
                Console.WriteLine("Exempt");
            }
            else 
            {
                Console.WriteLine("R$ " + tax.ToString("F2",CultureInfo.InvariantCulture));
            }
        }

        static void Main(string[] args)
        {

            int menuOption;

            Console.WriteLine
            ("Choose the option you want: "

                + "\n1 - Check if a number is positive."

                + "\n2 - Check if a number is pair."

                + "\n3 - Check if a number is multiple."

                + "\n4 - Calculate the duration of a game."

                + "\n5 - Perform the purchase of a product."

                + "\n6 - Check what range a number is in."

                + "\n7 - Check the quadrant that the coordinate is in."

                + "\n8 - Check the salary tax."
            );

            //If there is no option in the menu, the program will be closed
            menuOption = int.Parse(Console.ReadLine());
            switch (menuOption)
            {
                case 1:
                    IsPositive();
                    break;
                case 2:
                    IsPair();
                    break;
                case 3:
                    IsMultiple();
                    break;
                case 4:
                    GameDuration();
                    break;
                case 5:
                    PurchaseProduct();
                    break;
                case 6:
                    NumberInterval();
                    break;
                case 7:
                    QuadrantCoordinate();
                    break;
                case 8:
                    TaxAmount();
                    break;
                default:
                    break;
            }
        }
    }
}
