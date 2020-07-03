using System;

namespace Objects_Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[10];

            Console.Write("How many bedrooms will be rented ? ");
            int QuantityBedrooms = int.Parse(Console.ReadLine());

            for (int i = 1; i <= QuantityBedrooms; i++)
            {
                Console.WriteLine($"\nRent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Bedroom: ");
                int bedroom = int.Parse(Console.ReadLine());

                //Creating the student object with the received data
                student[bedroom] = new Student(name, email);
            }

            Console.WriteLine("\nOccupied bedrooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (student[i] != null)
                {
                    Console.WriteLine(i + ": " + student[i]);
                }
            }
        }   
    }
}
