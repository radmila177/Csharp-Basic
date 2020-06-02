using MovieStoreLibrary;
using MovieStoreLibrary.Enum;
using MovieStoreServices;
using System;

namespace MovieStoreConsole
{
    class Program
    {
        private static UserService _userService = new UserService();
        private static HelperService _helperService = new HelperService();
        private static MovieService _movieService = new MovieService();
        private static RegisterService _registerService = new RegisterService();

        private static User _loggedUser = null;

        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Do you want to login or register? ");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                int userChoice = _helperService.ValidatePositiveNumber(Console.ReadLine(), 2);
                
                // 1. Login 
                if (userChoice == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter Username");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        string password = Console.ReadLine();

                        _loggedUser = _userService.LogIn(username, password);

                        if (_loggedUser == null)
                        {
                            _helperService.ErrorMessage("Wrong username or password");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Welcome {username}!");
                            break;
                            //_userService.PrintUsers();
                        }

                    }

                }

                // 2. Register 
                else if (userChoice == 2)
                {
                    _loggedUser = _registerService.Registration();

                }
                else
                {
                    Console.Clear();
                    continue;
                }

                //role -user or employee
                if (_loggedUser.Role == Role.user)
                {
                    Console.WriteLine("Please select one of the following options: ");
                    Console.WriteLine("1) Show my movies");
                    Console.WriteLine("2) Show all movies");
                    Console.WriteLine("3) Rent a movies"); 

                    string inputChoice = Console.ReadLine();

                    switch (inputChoice)
                    {
                        case "1":
                            _movieService.MyRentedMovies();
                            break;

                        case "2":
                            _movieService.PrintMovies();
                            break;

                        case "3":
                            _movieService.MovieForRent();
                            break;

                        default:
                            Console.WriteLine("You have entered a non existing option");
                            break;
                    }
                  
                }
                else if (_loggedUser.Role == Role.employee)
                {
                    Console.WriteLine("Please select one of the following options: ");
                    Console.WriteLine("1) Print all users");
                    Console.WriteLine("2) Print all movies");
                    Console.WriteLine("3) Delete a user");
                    Console.WriteLine("4) Register a new a user");
                 

                    string inputChoice = Console.ReadLine();

                    switch (inputChoice)
                    {
                        case "1":
                            _userService.PrintUsers();
                            break;

                        case "2":
                            _movieService.PrintMovies();
                            break;

                        case "3":
                            Console.WriteLine("Please enter the ID of the user you want to delete");
                            int id = int.Parse(Console.ReadLine());
                            _userService.RemoveUserById(id);
                            break;

                        case "4":
                            _registerService.Registration();
                            break;

                        default:
                            Console.WriteLine("You have entered a non existing option");
                            break;
                    }
                }
                else
                {
                    _helperService.ErrorMessage("Something went wrong.Please try again!");
                }

                    if (!_helperService.RunAgain()) break;
                    Console.Clear();
                }

            }
        }
    }

