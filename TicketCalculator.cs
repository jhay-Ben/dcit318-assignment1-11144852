using System;

public static class TicketPriceCalculator
{
    private const int BasePrice = 10;
    private const int Discount = 7;

    public static void Run()
    {
        Console.Clear();
        Console.Write("Enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age) && age >= 0)
        {
            int finalPrice = (age < 13 || age >= 65) ? BasePrice - Discount : BasePrice;
            Console.WriteLine($"Ticket Price: GHC{finalPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
        PromptContinue();
    }

    private static void PromptContinue()
    {
        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }
}
