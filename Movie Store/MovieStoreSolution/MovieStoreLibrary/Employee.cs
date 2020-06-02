using MovieStoreLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibrary
{
    public class Employee : Member
    {
        protected double? Salary { get; set; }
        public double HoursPerMonth { get; set; }
        public double? Bonus { get; set; }

        public Employee(string firstName, string lastName, int age, string userName, string password, DateTime date, double hours)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            DateOfRegistration = date;
            HoursPerMonth = hours;
            Role = Role.employee;
        }
        public void SetBonus()
        {
            if (HoursPerMonth > 160)
            {
                Bonus = 0.3;
            }
            else
            {
                Bonus = null;
            }
        }
         public void SetSalary()
        {
            Salary+=HoursPerMonth*Bonus;
        }
    }
}
