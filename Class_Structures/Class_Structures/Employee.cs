using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Class_Structures
{
    class Employee
    {
        public string Name;
        public double SalaryGross;
        public double Tax;

        public double SalaryLiquid() 
        {
            return (SalaryGross - Tax);
        }

        public void IncreaseSalary(double percentage) 
        {
            SalaryGross += (SalaryGross * percentage / 100); 
        }

        public override string ToString()
        {
            return Name + ", $ " + SalaryLiquid().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
