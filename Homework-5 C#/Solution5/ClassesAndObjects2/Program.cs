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
        public Driver MyDriver { get; set; }

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
            int performance1 = car1.CalculateSpeed(car1.MyDriver);
            int performance2 = car2.CalculateSpeed(car2.MyDriver);
            if (performance1 > performance2)
            {

                Console.WriteLine($"The winner of the race is {car1.Model} with a speed of {car1.Speed} KM/H" +
                    $" and it was driven by {car1.MyDriver.Name}");
            }
            else if (performance1 < performance2)
            {

                Console.WriteLine($"The winner of the race is {car2.Model} with a speed of {car2.Speed} KM/H" +
                    $" and it was driven by {car2.MyDriver.Name}");

            }
            else
            {
                Console.WriteLine($"Both cars {car1.Model} with {car1.MyDriver.Name} and {car2.Model} with {car2.MyDriver.Name} crossed the finnish line at the same time!");

            }
        }
        static Car ChooseCar()
        {
            Car[] myCar = new Car[]
            {
                new Car("Hyundai ", 170),
                new Car("Mazda", 200),
                new Car("Ferrari", 250),
                new Car("Porsche", 290)
            };

            Console.WriteLine($@"Choose car: 
For Hyundai input 1
For Mazda inpu 2
For Ferrari input 3
For Porsche input 4");

            bool carN = int.TryParse(Console.ReadLine(), out int carNumber);
            Car chooseCar = null;
            switch (carNumber)
            {
                case 1:
                    chooseCar = myCar[0];
                    break;
                case 2:
                    chooseCar = myCar[1];
                    break;
                case 3:
                    chooseCar = myCar[2];
                    break;
                case 4:
                    chooseCar = myCar[3];
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            return chooseCar;

        }

        static Driver ChooseDriver()
        {
            //Driver[] chosenDriver = new Driver[4];
            Driver[] myDriver = new Driver[]
            {
                new Driver("Bob ", 15),
                new Driver("Greg", 20),
                new Driver("Jill", 25),
                new Driver("Anne", 29)
            };
            Console.WriteLine($@"Choose driver: 
Fo Bob input 1
For Greg inpu 2
For Jill input 3
For Anne input 4");


            bool driverN = int.TryParse(Console.ReadLine(), out int driverNumber);
            Driver chooseDriver = null;
            switch (driverNumber)
            {
                case 1:
                    chooseDriver = myDriver[0];
                    break;
                case 2:
                    chooseDriver = myDriver[1];
                    break;
                case 3:
                    chooseDriver = myDriver[2];
                    break;
                case 4:
                    chooseDriver = myDriver[3];
                    break;
                default:
                    Console.WriteLine("Invalid input.");

                    break;
            }
            return chooseDriver;
        }

        static void Main(string[] args)
        {
            //Car[] cars = new Car[2];
            //Driver[] drivers = new Driver[2];

            //for (int n = 0; n < 2; n++)
            //{
            //    cars[n] = ChooseCar();
            //    cars[n].MyDriver = ChooseDriver();
            //}
            //for (int l = 0; l < 2; l++)
            //{
            //    //drivers[l] = ChooseDriver();

            //}
            Car car1;
            Car car2;

            Driver driver1;
            Driver driver2;

            while (true)
            {
                car1 = ChooseCar();
                while (true)
                {
                    car2 = ChooseCar();
                    string valid1 = car1.Model;
                    string valid2 = car2.Model;
                    if (valid1 == valid2)
                    {
                        Console.WriteLine("That car has already been taken.");
                        continue;
                    }
                    break;
                }

                driver1 = ChooseDriver();

                while (true)
                {
                    driver2 = ChooseDriver();
                    string driverValid1 = driver1.Name;
                    string driverValid2 = driver2.Name;

                    if (driverValid1 == driverValid2)
                    {
                        Console.WriteLine("That driver has already been selected.");
                        continue;
                    }
                    break;
                }

                car1.MyDriver = driver1;
                car2.MyDriver = driver2;

                RaceCars(car1, car2);

                Console.ReadLine();
            }

        }

    }
}

