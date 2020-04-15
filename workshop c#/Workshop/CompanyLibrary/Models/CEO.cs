using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLibrary.Models
{
    public class CEO: Employee
     {

        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }


        public CEO(string firstname, string lastname, Employee[] empl)
        {
            FirstName = firstname;
            LastName = lastname;
            Employees = empl;
            Salary = 1500;
            Shares = 1;
        }

        public void AddSharesPrice(double sharePrice)
        {
            SharesPrice = sharePrice;
        }

        public void PrintEmployees(Employee[] Employees)
        {
            Console.WriteLine($"Employees: ");

            foreach (var value in Employees)
            {
                Console.WriteLine($"{value.FirstName} {value.LastName}");
            }
            
        }
        public override double GetSalary()
        {
            return Salary += Shares * SharesPrice;
        }


    }
}
