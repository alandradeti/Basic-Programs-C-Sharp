using System;
using System.Globalization;

namespace Data_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            byte bedrooms;
            float price;

            string lastname;
            byte age;
            float height;

            Console.WriteLine("Enter your full name:");
            name = Console.ReadLine();

            Console.WriteLine("How many rooms do you have in your house?");
            bedrooms = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price of a product: ");
            price = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter your last name, age and height (same line separated by space):");
            string[] data = Console.ReadLine().Split(' ');
            lastname = data[0];
            age = byte.Parse(data[1]);
            height = float.Parse(data[2]);

            Console.WriteLine("{0}\n"
                + "{1}\n"
                + "{2}\n"
                + "{3}\n"
                + "{4}\n"
                + "{5}\n"
                , name, bedrooms, price.ToString("F2", CultureInfo.InvariantCulture), lastname, age, height.ToString("F2", CultureInfo.InvariantCulture)
            );
        }
    }
}
