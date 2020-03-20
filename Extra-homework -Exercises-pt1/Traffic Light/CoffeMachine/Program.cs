using System;

namespace CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome dear customer! Please select a drink:");
            Console.WriteLine("1. Espresso...........2$");
            Console.WriteLine("2. Macchiato........3,5$");
            Console.WriteLine("3. Latte..............4$");
            Console.WriteLine("4. Cappuccino.........6$");
            Console.WriteLine("5. Tea..............1,5$");
            
            bool inputChoice = int.TryParse(Console.ReadLine(), out  int input);

            if (!inputChoice)
            {
                Console.WriteLine("Please enter the corect input");
            }
            else if (input < 0 || input > 5)
            {
                Console.WriteLine("Please enter the corect input");
            }
            else
            {
                switch (input)
                {
                    case 1:
                        Price(2, "Espreso");

                        break;
                    case 2:
                        Price(3.5, "Macchiato");

                        break;
                    case 3:
                        Price(4, "Latte");
                        break;
                    case 4:
                        Price(6, "Cappuccino");
                        break;
                    case 5:
                        Price(1.5, "Tea");
                        break;
                    default:
                        break;
                }

                Console.ReadLine();
            }
        }
        static void Price(double price, string drink)
        {
            Console.WriteLine("Sugar level: 1 - 5");

            bool sugarSucces = int.TryParse(Console.ReadLine(), out int sugar);

            if (!sugarSucces || sugar < 1 || sugar > 5)
            {
                Console.WriteLine("Invalid input");
            }

            else
            {
                Console.WriteLine("Sugar level " + sugar);
            }

            Console.WriteLine("Please insert " + price + " $");
           
            bool inputPricee = double.TryParse(Console.ReadLine(), out double inputPrice);
            if (!inputPricee)
            {
                Console.WriteLine("Please enter the corect input");
            }
            else
            {
                if (inputPrice < price)
                {
                    double addMoney = price - inputPrice;
                    Console.WriteLine("The " + drink + " costs " + price + " you are missing " + addMoney + "$" + " to buy it");
                }
                else if (inputPrice > price)
                {
                    double returnMoney = inputPrice - price;
                    Console.WriteLine("The " + drink + " costs " + price + " here is your change of " + returnMoney + "$");
                }
                else
                {
                    Console.WriteLine("Enjoy drink your coffe");
                }
            }
        }
    }

}