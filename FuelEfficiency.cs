using System;

class Vehicle
{
    // Virtual method so derived classes can override
    public virtual double FuelEfficiency()
    {
        return 0; // default
    }
}

class Car : Vehicle
{
    public override double FuelEfficiency()
    {
        return 6; // 6L per 100km
    }
}

class Motorcycle : Vehicle
{
    public override double FuelEfficiency()
    {
        return 3; // 3L per 100km
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a vehicle type:");
        Console.WriteLine("1. Car");
        Console.WriteLine("2. Motorcycle");
        Console.Write("Enter your choice (1 or 2): ");
        string choice = Console.ReadLine();

        Vehicle vehicle;

        if (choice == "1")
        {
            vehicle = new Car();
        }
        else if (choice == "2")
        {
            vehicle = new Motorcycle();
        }
        else
        {
            Console.WriteLine("Invalid choice!");
            return;
        }

        Console.Write("Enter distance traveled (in km): ");
        double distance = double.Parse(Console.ReadLine());

        double fuelUsed = (distance / 100) * vehicle.FuelEfficiency();

        Console.WriteLine($"\nFuel consumption: {fuelUsed:F2} liters");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
