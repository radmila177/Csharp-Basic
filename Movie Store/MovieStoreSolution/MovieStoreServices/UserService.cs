using MovieStoreLibrary;
using MovieStoreLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStoreServices
{
    public class UserService
    {
        //public User[] Users { get; set; }
        public List<User> Users { get; set; }

        private  HelperService _helperService = new HelperService();
        public UserService()
            {
            Users =  new List<User>
            { 
                    new User()
                    {
                        FirstName = "Radmila", LastName = "Sokolovska", Age = 34, UserName="radmila_s", Password = "radmila123",
                        Role = Role.employee, MemberNumber= 1
                    },
                   new User()
                   {
                        FirstName = "Petre", LastName = "Petreski", Age = 24, UserName="petre_p", Password = "petre123",
                        Role = Role.user, MemberNumber= 2
                   },
                  
                };
            }

        public User LogIn(string username, string password)
        {
            foreach (User user in Users)
            {
                if (user.UserName == username && user.Password == password)
                    return user;
            }
            return null;
        }
        //public User Register(User user)
        //{

        //    User[] newArr = Users;
        //    Array.Resize(ref newArr, newArr.Length + 1);
        //    newArr[newArr.Length - 1] = user;
        //    Users = newArr;

        //    return Users[Users.Length - 1];
        //}
        public User Register(User user)
        {
            if (!_helperService.ValidateStringLength(user.FirstName, 2) ||
               !_helperService.ValidateStringLength(user.LastName, 2) ||
               !_helperService.ValidateStringLength(user.UserName, 5))
            {
                return null;
            }
            if (!_helperService.ValidatePassword(user.Password))
            {
                return null;
            };
            Users.Add(user);

            return Users.LastOrDefault();
        }
        public void PrintUsers()
        {
            Console.WriteLine("Users:");
            foreach (User user in Users)
            {
                Console.WriteLine(user.UserInfo());
            }
        }

        public void RemoveUserById(int id)
        {
            User foundUser = Users.FirstOrDefault(user => user.MemberNumber == id);

            if (foundUser != null)
            {
                Users.Remove(foundUser);
            }
            else
            {
                Console.WriteLine($"A user with the specified id {id} does not exist");
            }
        }
        //public int id()
        //{
        //    int id = Users.Length + 1;
        //    return id;
        //}
    }
}

