using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public enum VehicleType { Car, Truck, Motorcycle, Boat, Tractor, SUV, Spaceship} // Types in the Class? Made the enum.
    public class Vehicle // Classes are singular.
    {
        // 01 Access Modifier
        // 02 Type
        // 03 Name
        // 04 Getteres & Setters

        public string Make { get; set; } // Make-Up of the property.
        public string Model { get; set; }
        public double Milage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
    }
}
