using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Value { get; set; }
        public int Period { get; set; }

        public Vehicle(string brand, string model, int value, int period) 
        {
            Brand = brand;
            Model = model;
            Value = value;
            Period = period;

        }
    }
}
