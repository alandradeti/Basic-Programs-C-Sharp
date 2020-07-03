using System;

namespace While_Structure
{
    class Program
    {
        //Method to read a password and validate it
        static void CheckPassword()
        {
            Console.WriteLine("Enter your password: ");
            int password = int.Parse(Console.ReadLine());

            while (password != 2002)
            {
                Console.WriteLine("Invalid password");
                Console.WriteLine("Enter your password:");
                password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Access Allowed");
        }

        //Method to check which quadrant the point is in
        static void QuadrantCoordinate()
        {
            int x, y;
            string[] points;

            Console.WriteLine("Enter the points X and Y separated by space: ");
            points = Console.ReadLine().Split(' ');

            x = int.Parse(points[0]);
            y = int.Parse(points[1]);

            if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("First");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Second");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Third");
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("fourth");
            }

        }

        //Method that counts the votes of each fuel
        static void PreferredFuel()
        {
            int type = 0;
            int alcohol = 0, gasoline = 0, diesel = 0;

            while (type != 4)
            {
                Console.WriteLine("Type your preferred fuel type: ");
                type = int.Parse(Console.ReadLine());

                if (type == 1)
                {
                    alcohol++;
                }
                else if (type == 2)
                {
                    gasoline++;
                }
                else if (type == 3)
                {
                    diesel++;
                }
            }

            Console.WriteLine
            (
                "MUITO OBRIGADO\n"
                + "Alcohol: {0}\n"
                + "Gasoline: {1}\n"
                + "Diesel: {2}"
                , alcohol, gasoline, diesel
            );
        }

        static void Main(string[] args)
        {

            int menuOption;

            Console.WriteLine
            ("Choose the option you want: "

                + "\n1 - Verify a fixed password."

                + "\n2 - Check the quadrant that the coordinate is in."

                + "\n3 - Check which fuel is most used."

            );

            //If there is no option in the menu, the program will be closed
            menuOption = int.Parse(Console.ReadLine());
            switch (menuOption)
            {
                case 1:
                    CheckPassword();
                    break;
                case 2:
                    QuadrantCoordinate();
                    break;
                case 3:
                    PreferredFuel();
                    break;
                default:
                    break;
            }
        }
    }
}
