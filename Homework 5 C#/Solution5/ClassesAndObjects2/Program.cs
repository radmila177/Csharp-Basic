using System;

namespace ClassesAndObjects2
{
    public class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }

        public Driver(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }
    }
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver myDriver { get; set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }


        public int CalculateSpeed(Driver driver)
        {
            int totalSpeed = driver.Skill * Speed;
            return totalSpeed;
        }
    }
    class Program
    {
        static void RaceCars(Car car1, Car car2)
        {

        }
        static void Main(string[] args)
        {
            
            //Car[] chosenCar = new Car[4];
            Car[] myCar = new Car[]
        {
                new Car("Hyundai ", 170),
                new Car("Mazda", 200),
                new Car("Ferrari", 250),
                new Car("Porsche", 290)
        };
            Console.WriteLine($@"Choose car number: 
For Hyundai input 1
For Mazda inpu 2
For Ferrari input 3
For Porsche input 4");


            bool carN = int.TryParse(Console.ReadLine(), out int carNumber);

            switch (carNumber)
            {
                case 1:
                    myCar[0] = myCar[0];
                    break;
                case 2:
                    myCar[1] = myCar[1];
                    break;
                case 3:
                    myCar[2] = myCar[2];
                    break;
                case 4:
                    myCar[3] = myCar[3];
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    
                    break;
            }
            
            Driver[] myDriver = new Driver[]
      {
                new Driver("Bob ", 15),
                new Driver("Greg", 20),
                new Driver("Jill", 25),
                new Driver("Anne", 29)
      };
            Console.WriteLine($@"Choose driver number: 
Fo Bob input 1
For Greg inpu 2
For Jill input 3
For Anne input 4");


            bool driverN = int.TryParse(Console.ReadLine(), out int driverNumber);

            switch (driverNumber)
            {
                case 1:
                    myDriver[0] = myDriver[0];
                    break;
                case 2:
                    myDriver[1] = myDriver[1];
                    break;
                case 3:
                    myDriver[2] = myDriver[2];
                    break;
                case 4:
                    myDriver[3] = myDriver[3];
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                 
                    break;
            }
          
            Console.ReadLine();
        }


    }
}