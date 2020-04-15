using CompanyLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLibrary.Models
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager() { }
        public Manager(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 1000;
            Role = RoleType.Menager;
        }
        public double AddBonus(double bonus)
        {
            return Bonus = bonus;
        }
        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
