using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter First number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Second number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("what operation would you want to be done: ( +, - , * , / )");
            char operation = char.Parse(Console.ReadLine());

            float result;
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    Console.WriteLine("The sum result is: " + result);
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    Console.WriteLine("The substraction result is: " + result);
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    Console.WriteLine("The multiplication result is: " + result);
                    break;
                case '/':
                    try { 
                    result = firstNumber / secondNumber;
                    Console.WriteLine("The division result is: " + result);
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.Write(e.Message);
                        Console.ReadLine();
                    }
                    break;

                default:
                    Console.WriteLine("Enter a valid input");
                    break;
            }


            Console.ReadLine();
        }
    }
}
