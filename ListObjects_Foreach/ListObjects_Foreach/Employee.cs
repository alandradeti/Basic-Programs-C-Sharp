using System;
using System.Globalization;

namespace ListObjects_Foreach
{
    class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(string id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        //Method that increases the salary
        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
