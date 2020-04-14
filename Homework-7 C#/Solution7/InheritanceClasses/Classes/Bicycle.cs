using InheritanceClasses.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClasses.Classes
{
    public class Bicycle: WheeledVehicle
    {
        public int NumberOfSpeedLevel { get; set; }
        public bool IsElectric { get; set; }

        public Bicycle() : base(VehicleType.bicycle)
        {
        }
        public void Ride()
        {
            Console.WriteLine("The bicycle is ready to ride!");
        }

        public override void Repair()
        {
            Console.WriteLine($@"The vehicle with Id:{Id}, Manufacturer: {Manufacturer},
            Model: {Model}, Number Of Wheels: {NumberOfWheels} Type: {Type} 
            with Number Of Speed Levels: {NumberOfSpeedLevel} needs to be repaired");
        }
    }
}
