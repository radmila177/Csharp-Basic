using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter First number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Second number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Third number");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Four number");
            int fourNumber = int.Parse(Console.ReadLine());

            var average = (firstNumber + secondNumber + thirdNumber + fourNumber) / 4;
            Console.WriteLine("The average of " + firstNumber + "," + secondNumber + "," + thirdNumber + " and " + fourNumber + " is: " + average);

        }
    }
    
}
