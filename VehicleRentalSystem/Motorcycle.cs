using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    internal class Motorcycle : Vehicle
    {
        public int Age { get; set; }
        public Motorcycle(string brand, string model, int value, int period, int age) : base(brand, model, value, period)
        {
            Age = age;
        }
    }
}
