using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    internal class Motorcycle : Vehicle
    {
        public int Age { get; set; }
        public Motorcycle(string customer, string brand, string model, int value, DateTime start, DateTime end, int age) 
            : base(customer, brand, model, value, start, end)
        {
            Age = age;
            int days = (end - start).Days;
            Cost = (days > 7) ? 10 : 15;
            Insurance = 0.02/100;
        }
    }
}
