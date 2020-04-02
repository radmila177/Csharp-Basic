using System;

namespace ClassesAndObjects
{
    public class Dog
    {

        public string DogName { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public void DogEating()
        {
            Console.WriteLine("The dog is now eating.");
        }
        public void DogPlaying()
        {
            Console.WriteLine("The dog is now playing.");
        }
        public void ChaseTail()
        {
            Console.WriteLine("Dog is now chasing its tail.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Enter Dog name");
            dog.DogName = Console.ReadLine();

            while (true)
            {
                int value;
                if (int.TryParse(dog.DogName, out value))
                {
                    Console.WriteLine("Invalid input. Please input a dog name.");
                    dog.DogName = Console.ReadLine();
                    continue;
                }
                else if(string.IsNullOrEmpty(dog.DogName))
                {
                    Console.WriteLine("Input is empty.Please input a dog name");
                    dog.DogName = Console.ReadLine();
                    continue;
                }
                break;
            }
           
                Console.WriteLine("Enter Dog race");
                dog.Race = Console.ReadLine();

            while (true)
            {
                int value1;
                if (int.TryParse(dog.Race, out value1))
                {
                    Console.WriteLine("Invalid input. Please input a race name.");
                     dog.Race = Console.ReadLine();
                     continue;
                }
                else if (string.IsNullOrEmpty(dog.Race))
                {
                    Console.WriteLine("Input is empty.Please input a race name");
                    dog.Race = Console.ReadLine();
                    continue;
                }
                 break;
             }

                    Console.WriteLine("Enter Dog color");
                    dog.Color = Console.ReadLine();

                    while (true)
                    {
                int value2;
                if (int.TryParse(dog.Color, out value2))
                {
                    Console.WriteLine("Invalid input. Please input a dog color.");
                    dog.Color = Console.ReadLine();
                    continue;
                }
                else if (string.IsNullOrEmpty(dog.Color))
                {
                    Console.WriteLine("Input is empty.Please input a dog color.");
                    dog.Color = Console.ReadLine();
                    continue;
                }
                    break;
                }
                    Console.WriteLine(@"Choose the activity you want for your dog:
If you want your dog eat input: 1
If you want your dog play input: 2
If you want your dog chase his tail input: 3");

                    bool inputSuccess = int.TryParse(Console.ReadLine(), out int activityInput);

                    if (!inputSuccess || activityInput < 1 || activityInput > 3)
                    {
                        Console.WriteLine("Ivalid input");
                    }
                    else
                    {
                        switch (activityInput)
                        {
                            case 1:
                                dog.DogEating();
                                break;
                            case 2:
                                dog.DogPlaying();
                                break;
                            case 3:
                                dog.ChaseTail();
                                break;
                        }

                    }
                    Console.ReadLine();
        }

    }
}