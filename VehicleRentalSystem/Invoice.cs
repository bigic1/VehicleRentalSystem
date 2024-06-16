using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace VehicleRentalSystem
{
    internal class Invoice
    {
        public Invoice(Vehicle v) 
        {

            Console.WriteLine("XXXXXXXXXX");
            Console.WriteLine("Date:" + DateTime.Today.ToString("yyyy-MM-dd"));
            Console.WriteLine("Customer Name: " + v.Customer);
            Console.WriteLine("Rented Vehicle: " + v.Brand + " " + v.Model);
            Console.WriteLine("");
            Console.WriteLine("Reservation start date: " + v.StartDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Reservation end date: " + v.EndDate.ToString("yyyy-MM-dd"));
            int days = (v.EndDate - v.StartDate).Days;
            Console.WriteLine("Reserved rental days: " + days);
            Console.WriteLine("");
            int actdays = (DateTime.Today.Date - v.StartDate).Days;
            Console.WriteLine("Actual Return date: " + DateTime.Today.ToString("yyyy-MM-dd"));
            Console.WriteLine("Actual rental days: " + actdays);
            Console.WriteLine("");
            Console.WriteLine("Rental cost per day:" + v.Cost);
            double insurance = (v.Value * v.Insurance);
            double increase = GetIncrease(v);
            if (increase != 0)
            {
                double inc = v.Insurance * v.Value * increase;
                Console.WriteLine("Initial insurance per day: " + insurance);
                Console.WriteLine("Insurance " + ((increase > 0) ? "increase" : "discount") + " per day: " + Math.Abs(inc));
                insurance += inc;

            }
            Console.WriteLine("Insurance per day:" + insurance);
            Console.WriteLine("");
            double rent = v.Cost * days;
            insurance *= days;
            if (actdays < days)
            {
                double rentdiscount;
                double insdiscount;
                int diff = days - actdays;
                rentdiscount = (v.Cost * diff) / 2;
                insdiscount = (insurance / days) * diff;
                Console.WriteLine("Early return discount for rent: " + rentdiscount);
                Console.WriteLine("Early return discount for insurance: " + insdiscount);
                rent -= rentdiscount;
                insurance -= insdiscount;
            }
            Console.WriteLine("Total rent: " + rent);
            Console.WriteLine("Total insurance: " + insurance);
            Console.WriteLine("Total: " + (rent+insurance));
        

        }
        double GetIncrease(Vehicle v)
        {
            double increase = 0;
            if (v.GetType() == typeof(Car))
            {
                int rating = ((Car)v).Rating;
                if (rating >= 4)
                {
                    increase = -0.1;
                }
            }
            else if (v.GetType() == typeof(Motorcycle))
            {
                int age = ((Motorcycle)v).Age;
                if (age < 25)
                {
                    increase = 0.2;
                }
            }
            else if (v.GetType() == typeof(CargoVan))
            {
                int exp = ((CargoVan)v).Experience;
                if (exp > 5)
                {
                    increase = -0.15;
                }
            }
            return increase;
        }
    }
}
