# Vehicle Rental System

This is a .NET C# console application which calculates the rental and insurance costs of different types of vehicles.
The application includes the following classes:
- Vehicle - the parent class which contains properties common to all vehicles.
- Car, Motorcycle, CargoVan - the child classes of Vehicle. They contain additional properties unique to these vehicle types.
- Invoice - the class that generates and prints invoices. It contains the GetIncrease() method which returns the increase or decrease of the insurance rate
