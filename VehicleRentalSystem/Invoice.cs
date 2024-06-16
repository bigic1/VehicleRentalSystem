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
        public Invoice(Vehicle v, DateTime invoicedate) 
        {

            Console.WriteLine("XXXXXXXXXX");
            Console.WriteLine("Date:" + invoicedate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Customer Name: " + v.Customer);
            Console.WriteLine("Rented Vehicle: " + v.Brand + " " + v.Model);
            Console.WriteLine("");
            Console.WriteLine("Reservation start date: " + v.StartDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Reservation end date: " + v.EndDate.ToString("yyyy-MM-dd"));
            int days = (v.EndDate - v.StartDate).Days; // rental days
            Console.WriteLine("Reserved rental days: " + days + " days");
            Console.WriteLine("");
            int actdays = (invoicedate - v.StartDate).Days; // actual rental days
            Console.WriteLine("Actual return date: " + invoicedate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Actual rental days: " + actdays + " days");
            Console.WriteLine("");
            Console.WriteLine("Rental cost per day: $" + v.Cost.ToString("F")); //ToString("F") - 2 decimal places
            double insurance = (v.Value * v.Insurance); // insurance cost per day
            double increase = GetIncrease(v); //insurance price increase/discount as a faction of insurance price
            if (increase != 0)
            {
                double inc = insurance * increase; //insurance increase/discount per day
                Console.WriteLine("Initial insurance per day: $" + insurance.ToString("F"));
                Console.WriteLine("Insurance " + ((increase > 0) ? "increase" : "discount") + " per day: $" + Math.Abs(inc).ToString("F"));
                insurance += inc; //the insurance price per day is being increased/reduced by the increase/discount

            }
            Console.WriteLine("Insurance per day: $" + insurance.ToString("F"));
            Console.WriteLine("");
            double rent = v.Cost * days; // rent (without the early return discount)
            insurance *= days; // insurance (without the early return discount)
            if (actdays < days) // early return discount
            {
                double rentdiscount;
                double insdiscount;
                int diff = days - actdays;
                rentdiscount = (v.Cost * diff) / 2;
                insdiscount = (insurance / days) * diff;
                Console.WriteLine("Early return discount for rent: $" + rentdiscount.ToString("F"));
                Console.WriteLine("Early return discount for insurance: $" + insdiscount.ToString("F"));
                Console.WriteLine("");
                rent -= rentdiscount;
                insurance -= insdiscount;
            }
            Console.WriteLine("Total rent: $" + rent.ToString("F"));
            Console.WriteLine("Total insurance: $" + insurance.ToString("F"));
            Console.WriteLine("Total: $" + (rent+insurance).ToString("F"));
            Console.WriteLine("XXXXXXXXXX");


        }
        double GetIncrease(Vehicle v)
        {
            double increase = 0;
            if (v.GetType() == typeof(Car))
            {
                int rating = ((Car)v).Rating; //casting as the child class to access its property
                if (rating >= 4) //high safety rating
                {
                    increase = -0.1;
                }
            }
            else if (v.GetType() == typeof(Motorcycle))
            {
                int age = ((Motorcycle)v).Age;
                if (age < 25) //age under 25
                {
                    increase = 0.2;
                }
            }
            else if (v.GetType() == typeof(CargoVan))
            {
                int exp = ((CargoVan)v).Experience;
                if (exp > 5) //over 5 years experience
                {
                    increase = -0.15;
                }
            }
            return increase;
        }
    }
}
