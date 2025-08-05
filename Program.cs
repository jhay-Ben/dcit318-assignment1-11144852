using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("DCIT 318 - Assignment 1");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");

            switch (Console.ReadLine())
            {
                case "1":
                    GradeCalculator.Run();
                    break;
                case "2":
                    TicketPriceCalculator.Run();
                    break;
                case "3":
                    TriangleTypeIdentifier.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
