using System;

public static class GradeCalculator
{
    public static void Run()
    {
        Console.Clear();
        Console.Write("Enter a numerical grade (0-100): ");
        if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
        {
            char letter = grade switch
            {
                >= 90 => 'A',
                >= 80 => 'B',
                >= 70 => 'C',
                >= 60 => 'D',
                _ => 'F'
            };
            Console.WriteLine($"Letter Grade: {letter}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid grade.");
        }
        PromptContinue();
    }

    private static void PromptContinue()
    {
        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }
}
