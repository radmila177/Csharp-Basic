using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[6];

            Console.WriteLine("Enter six int number");
            
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] =int.Parse(Console.ReadLine());  //elementite od input se dodavaat na nizata
            }
         
            int even = 0;
            for (int i = 0; i < intArr.Length; i++)
            {
                if (intArr[i] % 2 == 0)
                {
                    even += intArr[i];
                }
            }
            Console.WriteLine("Sum of even number in array is: " + even);
        }
    }
}
