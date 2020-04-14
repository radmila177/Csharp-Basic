
using CompanyLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLibrary.Models
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson() { }
        public SalesPerson(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Salary = 500;
            Role = RoleType.Sales;
        }

        public void ExtendSuccessRevenue(int number)
        {
            SuccessSaleRevenue = number;
        }

        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                return Salary + 800;
            }
            else
            {
                return Salary;
            }
        }
    }
}
