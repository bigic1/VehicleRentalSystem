namespace VehicleRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car vech1 = new Car("Mitsubishi", "Mirage", 100, 1000, 4);
            Invoice inv1 = new Invoice(vech1);
            inv1.InvoiceReturn();
            Console.WriteLine(vech1.Rating);
            Console.WriteLine("Hello, World!");
        }
    }
}
