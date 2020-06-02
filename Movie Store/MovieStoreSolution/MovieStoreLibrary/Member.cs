using MovieStoreLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibrary
{
    public class Member
    {
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Role Role { get; set; }

        public Member() { }
        public Member(Role role)
        {
            Role = role;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} | Registered on: {DateOfRegistration.ToShortDateString()}");
        }

    }
}
