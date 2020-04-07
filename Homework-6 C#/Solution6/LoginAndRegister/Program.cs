using LoginAndRegister.Model;
using System;

namespace LoginAndRegister
{
    class Program
    {
        static void Login(User[] userArray)
        {
            Console.WriteLine("Login form:");
            Console.WriteLine("Enter your Username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            bool successfull = false;
            while (!successfull)
            {
                foreach (var user in userArray)
                {
                    if (username == user.UserName && password == user.Password)
                    {
                        Console.WriteLine($"Welcome {user.UserName}! Here is your message:");

                        foreach (var message in user.Messages)
                        {
                            Console.WriteLine(message);
                            successfull = true;
                        }
                    }
                }

                if (!successfull)
                {
                    Console.WriteLine("Your username or password is incorect, try again !");
                    Login(userArray);
                }
                break;

            }
        }

        static void validateUser(int Id, string userName, User[] userArray)
        {
            User registerUser = new User();
            Console.WriteLine("Registration form:");
            Console.WriteLine("Enter your id:");
            registerUser.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your username:");
            registerUser.UserName = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            registerUser.Password = Console.ReadLine();


            bool isValid = false;
            while (!isValid)
            {
                foreach (var users in userArray)
                {
                    if (registerUser.UserName == users.UserName && registerUser.Id == users.Id)
                    {
                        Console.WriteLine("Your username or password exist, try again.");

                        validateUser(Id, userName, userArray);
                        isValid = true;

                    }
                }
                if (!isValid)
                {
                    //Register(userArray);
                    //isValid = false;
                    Array.Resize(ref userArray, userArray.Length + 1);
                    userArray[userArray.Length - 1] = registerUser;

                    Console.WriteLine("Registration complete! Users: \n");
                    foreach (var user in userArray)
                    {
                        Console.WriteLine($"Id: {user.Id} UserName:{user.UserName} ");
                        isValid = true;
                    }
                    Login(userArray);
                    
                }
            }

        }
        //static void Register(User[] userArray)
        //{
        //    User registerUser = new User();

        //    Array.Resize(ref userArray, userArray.Length + 1);
        //    userArray[userArray.Length - 1] = registerUser;

        //    Console.WriteLine("Registration complete! Users: \n");
        //    foreach (var user in userArray)
        //    {
        //        Console.WriteLine($"Id: {user.Id} UserName:{user.UserName} ");

        //    }
        //}
        
    static void Main(string[] args)
        {
            User registerUser = new User();
        
            User[] userArray = new User[]
            {
               new User(1, "Radmila", "Pass1", new string[] {"First message - from user1", "Second message - from user1"}),
               new User(2, "Jovana", "Pass2", new string[] {"First message - from user2", "Second message - from user2"}),
               new User(3, "Aleksandar", "Pass3", new string[] { "First message - from user3", "Second message - from user3" }),

            };


            bool succes = true;
            while (succes)
            {
                Console.WriteLine("Welcome to our page!");
                Console.WriteLine(@"For login please input: 1
For register please input: 2");
                bool inputParse = int.TryParse(Console.ReadLine(), out int selectNumber);

                switch (selectNumber)
                {
                    case 1:
                        {
                            Login(userArray);
                            succes = false;
                            break;
                        }
                    case 2:
                        {
                            validateUser(registerUser.Id, registerUser.UserName, userArray);
                            succes = false;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

            }
            Console.ReadLine();
        }
}}