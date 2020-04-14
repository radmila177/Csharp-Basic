using CompanyLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLibrary.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor() { }
        public Contractor(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            WorkHours = 40;
            PayPerHour = 50;
        }
        public override double GetSalary()
        {
            return Salary = WorkHours * PayPerHour;
        }
    }
}