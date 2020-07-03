using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListObjects_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityEmployee;
            string searchId_employee;

            //Defining Employee type list
            List<Employee> listEmployee = new List<Employee>();
             
            Console.Write("How many employees will be registered? ");
            quantityEmployee = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= quantityEmployee; counter++) 
            {
                Console.WriteLine("Employee #{0}:", counter);

                Console.Write("Id: ");
                string id_employee = Console.ReadLine();

                Console.Write("Name: ");
                string name_employee = Console.ReadLine();

                Console.Write("Salary: ");
                double salary_employee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Adding Employee object data to the Employee type list
                listEmployee.Add(new Employee(id_employee, name_employee, salary_employee));

                Console.WriteLine("");
            }
            
            Console.Write("\nEnter the employee id that will have salary increase: ");
            searchId_employee = Console.ReadLine();

            //Employee such that Id_employee is equal to searchId
            Employee searchEmployee = listEmployee.Find(employee => employee.Id == searchId_employee);
            if (searchEmployee != null)
            {
                Console.Write("Enter the percentage: " );
                double percentageIncrease = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                searchEmployee.IncreaseSalary(percentageIncrease);

            }
            else 
            {
                Console.WriteLine("This employee does not exist!");
            }

            Console.WriteLine("");
            Console.WriteLine("Update list employees:");

            //Loop to scroll through the list of employees
            foreach (Employee employee in listEmployee)
            {
                Console.WriteLine(employee);
            }


        }
    }
}
