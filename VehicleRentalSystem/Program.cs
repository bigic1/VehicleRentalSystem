﻿namespace VehicleRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car veh1 = new("John Doe", "Mitsubishi", "Mirage", 15000, DateTime.Parse("June 07, 2024"), DateTime.Parse("June 17, 2024"), 3);
            Motorcycle veh2 = new("Mary Johnson", "Triumph", "Tiger Sport 660", 10000, DateTime.Parse("June 07, 2024"), DateTime.Parse("June 17, 2024"), 20);
            CargoVan veh3 = new("John Markson", "Citroen", "Jumper", 20000, DateTime.Parse("June 07, 2024"), DateTime.Parse("June 22, 2024"), 8);
            Invoice inv1 = new(veh1);
            Invoice inv2 = new(veh2);
            Invoice inv3 = new(veh3);
        }
    }
}
