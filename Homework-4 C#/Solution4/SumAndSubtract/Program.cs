using System;

namespace SumAndSubtract
{
    class Program
    {
        static int Sum(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        static int Subtract(int number1, int number2)
        {
            int result1 = number1 - number2;
            return result1;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter two numbers:");
            bool inputNumber1 = int.TryParse(Console.ReadLine(), out int num1);

            if (!inputNumber1)
            {
                Console.WriteLine("Please enter a number:");
            }
           
            bool inputNumber2 = int.TryParse(Console.ReadLine(), out int num2);

            if (!inputNumber2)
            {
                Console.Write("Please enter a number:");
            }

            Console.WriteLine("What operation would you want to be done: ( +, - )");
            bool operators = char.TryParse(Console.ReadLine(), out char operation);

            if (!operators)
            {
                Console.WriteLine("Invalid operator.Please enter a corect operator.");
            }
            else
            {
                switch (operation)
                {
                    case '+':
                        Console.WriteLine($"The sum of {num1} and {num2} is {Sum(num1, num2)}");
                        break;
                    case '-':
                        Console.WriteLine($"The substraction of {num1} and {num2} is {Subtract(num1, num2)}");
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.ReadLine();
            }
        }

    }
}