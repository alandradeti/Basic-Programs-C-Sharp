using System;
using System.Globalization;

namespace Class_Structures
{
    class Program
    {
        static void RectangleData() 
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Enter the width and height of the rectangle:");
            rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETER = " + rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }

        static void EmployeeData() 
        {
            Employee employee = new Employee();

            Console.WriteLine("Enter name, gross salary and tax: ");
            employee.Name = Console.ReadLine();
            employee.SalaryGross = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Employee: " + employee);

            Console.WriteLine("Enter the percentage to increase the salary: ");
            employee.IncreaseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Updated data:" + employee);

        }

        static void StudentData() 
        {
            Student student = new Student();

            Console.WriteLine("Enter name: ");
            student.Name = Console.ReadLine();
            Console.WriteLine(student);

        }
        static void Main(string[] args)
        {

            int menuOption;

            Console.WriteLine
            ("Choose the option you want: "

                + "\n1 - Calculate the area, perimeter and diagonal of the rectangle."

                + "\n2 - Increase the salary of an employee."

                + "\n3 - To verify if the student is approved or not is to show how many points were missing to pass."

            );

            //If there is no option in the menu, the program will be closed
            menuOption = int.Parse(Console.ReadLine());
            switch (menuOption)
            {
                case 1:
                    RectangleData();
                    break;
                case 2:
                    EmployeeData();
                    break;
                case 3:
                    StudentData();
                    break;
                default:
                    break;
            }

            
            
            


        }
    }
}
