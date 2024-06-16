using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    internal class Invoice
    {
        public Vehicle v;
        public Invoice(Vehicle v) 
        {
            this.v = v;
        }
        public void InvoiceReturn() 
        {
            Console.WriteLine("XXXXXXXX");
            Console.WriteLine("Date:" + DateTime.Today.ToString("yyyy-MM-dd"));
            Console.WriteLine("Rented Vehicle: " + v.Brand + " " + v.Model);
            if (v.GetType() == typeof(Car))
            {
                Console.WriteLine(((Car)v).Rating);
                Console.WriteLine(v.Value);

            }
        

        }
    }
}
