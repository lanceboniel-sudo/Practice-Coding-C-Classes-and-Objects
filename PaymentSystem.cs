using System;

namespace PaymentSystem
{
    // Step 1: Create an interface
    interface IPayment
    {
        double ProcessPayment(double amount);
    }

    // Step 2: Implement CreditCardPayment with 2% service charge
    class CreditCardPayment : IPayment
    {
        public double ProcessPayment(double amount)
        {
            double serviceCharge = amount * 0.02;
            return amount + serviceCharge;
        }
    }

    // Step 3: Implement PayPalPayment with $5 fixed fee
    class PayPalPayment : IPayment
    {
        public double ProcessPayment(double amount)
        {
            double fixedFee = 5.0;
            return amount + fixedFee;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Payment Method (1 = Credit Card, 2 = PayPal):");
            string choice = Console.ReadLine();

            Console.Write("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            IPayment payment;

            if (choice == "1")
            {
                payment = new CreditCardPayment();
            }
            else if (choice == "2")
            {
                payment = new PayPalPayment();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            double finalAmount = payment.ProcessPayment(amount);
            Console.WriteLine($"Final amount to be paid: ${finalAmount:F2}");
        }
    }
}
