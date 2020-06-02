using MovieStoreLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibrary
{
    public class User : Member 
    {
        public int MemberNumber { get; set; }
        public SubscriptionType TypeOfSubscription { get; set; }
        public List<Movie> Movies { get; set; }

        public User() {
            TypeOfSubscription = SubscriptionType.Monthly;
        }
        public User(string firstName, string lastName, int age, string userName, string password, DateTime date)
        {
           
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            DateOfRegistration = date;
           
            //Movies = movies;
            Role = Role.user;
        }
        public string UserInfo()
        {
            return $"{FirstName} {LastName} membership: {TypeOfSubscription} registered on: {DateOfRegistration}";
        }
    }

        
}

  


