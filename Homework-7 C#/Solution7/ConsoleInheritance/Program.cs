using InheritanceClasses.Classes;
using InheritanceClasses.Enums;
using System;

namespace ConsoleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle opel = new Vehicle()
            {
                Id = 1,
                Manufacturer = "Opel",
                Model = "Corsa",
            };
            opel.PrintInfo();
            Console.WriteLine("---------------------------------------------------------------");


            WheeledVehicle fiat = new WheeledVehicle()
            {
                Id = 2,
                Manufacturer = "Fiat",
                Model = "Sedici",
                NumberOfWheels = 4,
                Type = VehicleType.car
            };
            fiat.Repair();
            Console.WriteLine("---------------------------------------------------------------");


            Bicycle bmx = new Bicycle()
            {
                Id = 3,
                Manufacturer = "BMX",
                Model = "bmx-1",
                NumberOfWheels = 2,
                NumberOfSpeedLevel = 7,
            };
            bmx.PrintInfo();
            bmx.Repair();
            bmx.Ride();
            Console.WriteLine("---------------------------------------------------------------");

            Car ford = new Car(EngineType.diesel)
            {
                Id = 4,
                Manufacturer = "Toyota",
                Model = "Corolla",
                NumberOfWheels = 4,
                FuelConsumption = 7,
                NumberOfDoors = 4,
                MaxSpeed = 200,
            };

            ford.PrintInfo();
            ford.Repair();
            ford.Drive();
            Console.WriteLine("---------------------------------------------------------------");


            ElectricCar car = new ElectricCar()
            {
                Id = 5,
                Manufacturer = "Tesla",
                Model = "X",
                NumberOfWheels = 4,
                FuelConsumption = 0,
                NumberOfDoors = 4,
                BatteryCapacity = 100,
                BatteryPercentage = 10,
                MaxSpeedBattery = 110,
                MaxSpeed = 220,
            };
            car.PrintInfo();
            car.Recharge();
            car.Repair();
            car.Drive();

            Console.ReadLine();
        }
     
    }
    
}
