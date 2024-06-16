using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    internal class Car : Vehicle
    {
        public int Rating { get; set; }
        public Car(string customer, string brand, string model, int value, DateTime start, DateTime end, int rating)
            :base(customer, brand, model, value, start, end)
        {
            Rating = (rating>=0 && rating<=5) ? rating: 0;
            int days = (end - start).Days;
            Cost = (days > 7) ? 15 : 20;
            Insurance = 0.01/100;
        }
    }
}
