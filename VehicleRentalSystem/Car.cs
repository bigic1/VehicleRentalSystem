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
        public Car(string brand, string model, int value, int period, int rating):base(brand,model,value,period)
        {
            Rating = rating;
        }
    }
}
