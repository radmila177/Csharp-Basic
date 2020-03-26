using System;

namespace Methods
{
    class Program
    {

        static void Substrings()
        {

            string xString = "Hello from SEDC Codecademy v7.0";
            Console.WriteLine("Hello from SEDC Codecademy v7.0");
            Console.WriteLine($"Please enter one number to {xString.Length}");

            bool inputNumber = int.TryParse(Console.ReadLine(), out int number);

            if (!inputNumber)
            {
                Console.WriteLine("Please enter the number");
            }
            else if (number < 1 || number > xString.Length)
            {
                Console.WriteLine("Please enter the corect number");
            }
            else
            {
                string nCharacter = xString.Substring(0, number);
                Console.WriteLine($"The new string is {nCharacter}.");
                Console.WriteLine($"The lenght of new string is: {nCharacter.Length}");
            }

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Substrings();
        }
    }
}
