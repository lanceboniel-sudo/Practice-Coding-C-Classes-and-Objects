using System;

// Define the interface
interface IPayment
{
    double ProcessPayment(double amount);
}

// Implement CreditCardPayment
class CreditCardPayment : IPayment
{
    public double ProcessPayment(double amount)
    {
        // Add 2% service charge
        double finalAmount = amount + (amount * 0.02);
        return finalAmount;
    }
}

// Implement PayPalPayment
class PayPalPayment : IPayment
{
    public double ProcessPayment(double amount)
    {
        // Add fixed $5 fee
        double finalAmount = amount + 5;
        return finalAmount;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a payment method:");
        Console.WriteLine("1. Credit Card");
        Console.WriteLine("2. PayPal");
        Console.Write("Enter your choice (1 or 2): ");
        string choice = Console.ReadLine();

        IPayment paymentMethod;

        if (choice == "1")
        {
            paymentMethod = new CreditCardPayment();
        }
        else if (choice == "2")
        {
            paymentMethod = new PayPalPayment();
        }
        else
        {
            Console.WriteLine("Invalid choice!");
            return;
        }

        Console.Write("Enter the amount: ");
        double amount = double.Parse(Console.ReadLine());

        double finalAmount = paymentMethod.ProcessPayment(amount);

        Console.WriteLine($"\nFinal amount to be paid: ${finalAmount:F2}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
