using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    internal class CargoVan : Vehicle
    {
        public int Experience { get; set; }
        public CargoVan(string customer, string brand, string model, int value, DateTime start, DateTime end, int experience) 
            : base(customer, brand, model, value, start, end)
        {
            Experience = experience;
            int days = (end - start).Days;
            Cost = (days > 7) ? 40 : 50;
            Insurance = 0.03 / 100;

        }
    }
}
