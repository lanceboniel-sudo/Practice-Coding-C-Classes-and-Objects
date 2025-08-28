using System;

abstract class Appliance
{
    public abstract void TurnOn();
}

class WashingMachine : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Washing Machine is running");
    }
}

class Refrigerator : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Refrigerator is cooling");
    }
}

class Program
{
    static void Main()
    {
        while (true) // loop until user exits
        {
            Console.WriteLine("\nChoose an appliance to turn on:");
            Console.WriteLine("1. Washing Machine");
            Console.WriteLine("2. Refrigerator");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Appliance appliance;

            if (choice == "1")
            {
                appliance = new WashingMachine();
                appliance.TurnOn();
            }
            else if (choice == "2")
            {
                appliance = new Refrigerator();
                appliance.TurnOn();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Exiting program...");
                break; // stop the loop
            }
            else
            {
                Console.WriteLine("Invalid choice! Try again.");
            }
        }
    }
}
