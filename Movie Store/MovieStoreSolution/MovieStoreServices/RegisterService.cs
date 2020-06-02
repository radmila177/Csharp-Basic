using MovieStoreLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreServices
{
    public class RegisterService
    {
        private static UserService _userService = new UserService();
        private static HelperService _helperService = new HelperService();
        public User Registration()
        {
            User _regiteredUser = null;

            while (true)
            {
                Console.WriteLine("Enter the first name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter the last name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter the username:");
                string userName = Console.ReadLine();

                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();

                Console.WriteLine("Enter your age:");
                int age = int.Parse(Console.ReadLine());

                
                Console.WriteLine("Enter your phone number");
                int phoneNumber = int.Parse(Console.ReadLine());

                //Console.WriteLine("Enter your id");
                //int id = int.Parse(Console.ReadLine());

                DateTime dateRegister = DateTime.Now;

                User newUser = new User(firstName, lastName, age, userName, password, dateRegister);

                _regiteredUser = _userService.Register(newUser);

                if (_regiteredUser == null)
                {
                    _helperService.ErrorMessage("Register not successfull! Please try again! ");

                }
                else
                {
                    Console.Clear();
                    break;
                }
            }

            return _regiteredUser;

        }
    }
}
