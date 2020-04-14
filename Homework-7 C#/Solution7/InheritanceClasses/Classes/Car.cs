using InheritanceClasses.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClasses.Classes
{
    public class Car: WheeledVehicle
    {
        public EngineType EngineType { get; set; }
        public int FuelConsumption { get; set; }
        public int NumberOfDoors { get; set; }
        public int MaxSpeed { get; set; }

   
        public Car() : base(VehicleType.car) { }

        public Car(EngineType type):base(VehicleType.car)
        {
            EngineType = type;
        }
        public virtual void Drive()
        {
            Console.WriteLine("The car is ready to drive!");
        }
        public override void Repair()
        {
            Console.WriteLine($@"The vehicle Id: {Id}, Manufacturer: {Manufacturer}, 
            Model: {Model}, Type: {Type}, Number of wheels: {NumberOfWheels},
            Engine Type: {EngineType}, Fuel consumption: {FuelConsumption}L, 
            Number of Doors: {NumberOfDoors}, Max Speed: {MaxSpeed} KM/H - need to be repaired.");
        }
    }
}
