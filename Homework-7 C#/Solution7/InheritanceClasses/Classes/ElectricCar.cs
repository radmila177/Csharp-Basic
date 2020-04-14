using InheritanceClasses.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClasses.Classes
{
    public class ElectricCar:Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryPercentage { get; set; }
        public int MaxSpeedBattery { get; set; }

        public ElectricCar() : base(EngineType.electric)
        { }

        public void Recharge()
        {
            Console.WriteLine("Electric Car is empty, need to recharge");
        }
        public override void Repair()
        {
            Console.WriteLine($@"The vehicle Id: {Id}, Manufacturer: {Manufacturer}, Model: {Model}, 
            Type: {Type}, Number of wheels: {NumberOfWheels},Engine Type: {EngineType}, 
            Fuel consumption: {FuelConsumption}L, Number of Doors: {NumberOfDoors},
            Max Speed: {MaxSpeed} KM/H, Max Speed on Battery: {MaxSpeedBattery} KM/H, 
            Battery Capacity: {BatteryCapacity} kWh, Battery Percentage: {BatteryPercentage} % 
            - the battery needs to be recharged");
        }
        public override void Drive()
        {
            Console.WriteLine($"Electric car is ready to drive with maximum speed of {MaxSpeed} KM/H !");
        }
    }
}
