using System;
using System.Globalization;

namespace Estrutura_Sequencial
{
    class Program
    {
        //Method that performs the sum of two numbers
        static void SumNumbers()
        {
            int firstNumber, secondNumber, sumResult;

            Console.WriteLine("Enter the first number:");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            sumResult = firstNumber + secondNumber;

            Console.WriteLine("SUM = " + sumResult);
        }

        //Method that calculates the area of ​​the circle
        static void CircleArea()
        {
            double radius,area;

            //Entering a decimal with a period instead of a comma
            Console.WriteLine("Enter the circle radius value:");
            radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = 3.14159 * Math.Pow(radius, 2);

            Console.WriteLine("Area =" + area.ToString("F4", CultureInfo.InvariantCulture));
        }

        //Method that makes the product difference of A and B by the product of C and D
        static void ProductDifference()
        {
            int a, b, c, d, difference;

            Console.WriteLine("Enter the value of A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of B:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of C:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of D:");
            d = int.Parse(Console.ReadLine());

            difference = (a * b - c * d);

            Console.WriteLine("DIFFERENCE = " + difference);

        }

        //Method that calculates an employee's hours worked
        static void WorkedHours()
        {
            int idEmployee, workedHours;
            float salary, hourValue;

            Console.WriteLine("Enter employee code: ");
            idEmployee = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter hours worked: ");
            workedHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount you receive per hour:");
            hourValue = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = workedHours * hourValue;

            Console.WriteLine
            (
                "NUMBER = {0}\n"
                + "SALARY = U$ {1}"
                , idEmployee, salary.ToString("F2", CultureInfo.InvariantCulture)
            );
        }

        //Method that performs the insertion and purchase of a product to use the split function
        static void PurchaseProduct() 
        {
            int idFirstProduct, idSecondProduct, quantityFirstProduct, quantitySecondProduct;
            float unitValueFirstProduct, unitValueSecondProduct, totalValue;


            Console.WriteLine("Enter part number 1, number of parts 1 and unit value of part 1:\n"
                + "(Separated by space)");
            string[] firstProduct = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter part 2 code, number of parts 2 and unit value of part 2:\n"
                + "(Separated by space)");
            string[] secondProduct = Console.ReadLine().Split(' ');

            idFirstProduct = int.Parse(firstProduct[0]);
            quantityFirstProduct = int.Parse(firstProduct[1]);
            unitValueFirstProduct = float.Parse(firstProduct[2], CultureInfo.InvariantCulture);
            idSecondProduct = int.Parse(secondProduct[0]);
            quantitySecondProduct = int.Parse(secondProduct[1]);
            unitValueSecondProduct = float.Parse(secondProduct[2], CultureInfo.InvariantCulture);

            totalValue = (unitValueFirstProduct * quantityFirstProduct) + (unitValueSecondProduct * quantitySecondProduct);

            Console.WriteLine("TOTAL AMOUNT PAYABLE: R$ " + totalValue.ToString("F2", CultureInfo.InvariantCulture));

        }

        //Method that calculates areas with the entry of three numbers using a floating point
        static void FloatingPointCalculation() 
        {
            double a, b, c, triangleArea, circleArea, trapezoidArea, squareArea, rectangleArea;

            Console.WriteLine("Enter the 3 values on each side separated by space: ");
            string[] numbers = Console.ReadLine().Split(' ');

            a = double.Parse(numbers[0], CultureInfo.InvariantCulture);
            b = double.Parse(numbers[1], CultureInfo.InvariantCulture);
            c = double.Parse(numbers[2], CultureInfo.InvariantCulture);

            triangleArea = (a * c) / 2;
            circleArea = Math.Pow(c,2) * 3.14159;
            trapezoidArea = (a + b) / 2.0 * c;
            squareArea = b * b;
            rectangleArea = a * b;

            Console.WriteLine
            (
                "TRIANGLE: {0}\n"
                + "CIRCLE: {1}\n"
                + "TRAPEZOID: {2}\n"
                + "SQUARE: {3}\n"
                + "RECTANGLE: {4}\n"
                ,triangleArea.ToString("F3", CultureInfo.InvariantCulture)
                ,circleArea.ToString("F3", CultureInfo.InvariantCulture)
                ,trapezoidArea.ToString("F3", CultureInfo.InvariantCulture)
                ,squareArea.ToString("F3", CultureInfo.InvariantCulture)
                ,rectangleArea.ToString("F3", CultureInfo.InvariantCulture)
            );
        }

        static void Main(string[] args)
        {
            int menuOption;

            Console.WriteLine
            ("Choose the option you want: "

                + "\n1 - Perform Sum of two numbers."

                + "\n2 - Calculate the area of a circle."

                + "\n3 - Realize the difference between the Product of A and B and the Product of C and D."

                + "\n4 - Calculate an employee's hours worked."

                + "\n5 - Perform the insertion and purchase of a product"

                + "\n6 - Perform calculation of areas with floating point."
            );

            //If there is no option in the menu, the program will be closed
            menuOption = int.Parse(Console.ReadLine());
            switch (menuOption) {
                case 1: 
                    SumNumbers();
                    break;
                case 2:
                    CircleArea();
                    break;
                case 3: 
                    ProductDifference();
                    break;
                case 4:
                    WorkedHours();
                    break;
                case 5: 
                    PurchaseProduct();
                    break;
                case 6: 
                    FloatingPointCalculation();
                    break;
                default:
                    break;
            }
        }
    }
}
