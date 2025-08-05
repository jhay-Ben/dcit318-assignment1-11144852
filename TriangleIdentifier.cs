using System;

public static class TriangleTypeIdentifier
{
    public static void Run()
    {
        Console.Clear();
        double[] sides = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter side {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out sides[i]) || sides[i] <= 0)
            {
                Console.WriteLine("Invalid input. All sides must be positive numbers.");
                PromptContinue();
                return;
            }
        }

        double a = sides[0], b = sides[1], c = sides[2];

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
                Console.WriteLine("Triangle Type: Equilateral");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }
        else
        {
            Console.WriteLine("Invalid triangle: The sum of any two sides must be greater than the third side.");
        }

        PromptContinue();
    }

    private static void PromptContinue()
    {
        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }
}
