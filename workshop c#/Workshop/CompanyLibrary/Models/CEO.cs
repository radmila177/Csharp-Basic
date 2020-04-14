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


        public CEO(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Salary = 1500;
            Shares = 1;
           
        }

        public double AddSharesPrice(double sharePrice)
        {
            return SharesPrice = sharePrice;
        }

        public string PrintEmployees()
        {
            return $"Employees: {Employees}";
        }

        public override double GetSalary()
        {
            return Salary += Shares * SharesPrice;
        }


    }
}
