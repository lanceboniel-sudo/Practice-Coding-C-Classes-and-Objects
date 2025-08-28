using System;

class Program
{
    // Enum for membership levels
    enum MembershipLevel
    {
        Basic = 1,
        Silver,
        Gold,
        Platinum
    }

    static void Main()
    {
        Console.WriteLine("Choose your Membership Level:");
        Console.WriteLine("1. Basic");
        Console.WriteLine("2. Silver");
        Console.WriteLine("3. Gold");
        Console.WriteLine("4. Platinum");

        Console.Write("Enter your choice (1-4): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 4)
        {
            MembershipLevel level = (MembershipLevel)choice;

            Console.WriteLine($"\nYou selected: {level}");

            // Display benefits
            switch (level)
            {
                case MembershipLevel.Basic:
                    Console.WriteLine("Benefits: Access to standard services only.");
                    break;
                case MembershipLevel.Silver:
                    Console.WriteLine("Benefits: Basic benefits + 5% discount on purchases.");
                    break;
                case MembershipLevel.Gold:
                    Console.WriteLine("Benefits: Silver benefits + free shipping.");
                    break;
                case MembershipLevel.Platinum:
                    Console.WriteLine("Benefits: Gold benefits + priority customer support + 20% discount.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid choice! Please run the program again and choose between 1-4.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
