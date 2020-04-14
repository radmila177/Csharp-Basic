using InheritanceClasses.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClasses.Classes
{
    public class WheeledVehicle: Vehicle
    {
        public int NumberOfWheels { get; set; }
        public VehicleType Type { get; set; }

        public WheeledVehicle() { }
        public WheeledVehicle(VehicleType type)
        {
            Type = type;
        }
        public virtual void Repair()
        {
            Console.WriteLine($@"The vehicle with Id:{Id}, Manufacturer: {Manufacturer}, 
            Model: {Model}, Number Of Wheels: {NumberOfWheels} and Type: {Type} 
            need to be repaired.");
        }

    }
}
