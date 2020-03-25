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
        static int Subtract(int num1, int num2)
        {
            int result1 = num1 - num2;
            return result1;
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter two numbers:");
            int inputNumber = int.Parse(Console.ReadLine());
            int inputNumber2 = int.Parse(Console.ReadLine());
            Console.WriteLine("What operation would you want to be done: ( +, - )");
            char operation = char.Parse(Console.ReadLine());

            if (operation == '+')
            {
                Console.WriteLine("The sum result is: " + Sum(inputNumber, inputNumber2));
              
            }
            else if(operation == '-')
            {
                Console.WriteLine("The substraction result is: " + Subtract(inputNumber, inputNumber2));
            }
            else
            {
                Console.WriteLine("Enter a valid input");
            }
           
            Console.ReadLine();
        }

    }
}

