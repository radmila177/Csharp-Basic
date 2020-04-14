using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClasses.Classes
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Vehicle with: Id:{Id}, Manufacturer: {Manufacturer} and Model: {Model}");
        }

    }
}
