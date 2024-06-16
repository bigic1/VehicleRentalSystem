using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    internal class Vehicle
    {
        public string Customer { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Insurance { get; set; }
        public int Cost { get; set; }

        public Vehicle(string customer, string brand, string model, int value, DateTime start, DateTime end) 
        {
            Customer = customer;
            Brand = brand;
            Model = model;
            Value = value;
            StartDate = start;
            EndDate = end;

        }
    }
}
