using CompanyLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLibrary.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleType Role { get; set; }
        protected double Salary { get; set; }
        
        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}. ");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }

    }
}
