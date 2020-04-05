using LoginAndRegister2.Model1;
using System;

namespace LoginAndRegister2
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] userArray = new User[]
           {
               new User(1, "Radmila", "Pass1", new string[] {"First message - from user1", "Second message - from user1"}),
               new User(2, "Jovana", "Pass2", new string[] {"First message - from user2", "Second message - from user2"}),
               new User(3, "Aleksandar", "Pass3", new string[] { "First message - from user3", "Second message - from user3" }),

           };
            Console.WriteLine(@"For login please input: 1
For register please input: 2");
            string loginRegister = Console.ReadLine();


            bool successfull = false;
            while (!successfull)
            {

                if (loginRegister == "1")
                {
                    Console.WriteLine("Write your username:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    string password = Console.ReadLine();


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
                        Console.WriteLine("Your username or password is incorect, try again!");
                    }

                }

                else if (loginRegister == "2")
                {
                    Console.WriteLine("Enter your id:");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter your username:");
                    string username = Console.ReadLine();

                    Console.WriteLine("Enter your password:");
                    string password = Console.ReadLine();

                    Array.Resize(ref userArray, userArray.Length + 1);
                    string[] message = null;
                    userArray[userArray.Length - 1] = new User(id, username, password, message);

                    foreach (var user in userArray)
                    {
                        Console.WriteLine($"UserName:{user.UserName}  Password:{user.Password}");
                        successfull = true;
                    }
                   
                }
                else
                {
                    Console.WriteLine("Try again.");
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
