using System;

namespace ConsoleApp1.Utilities
{
    public static class InputHelper
    {
        public static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;

                Console.WriteLine("Invalid number.");
            }
        }

        public static string ReadRequiredString(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    return input;

                Console.WriteLine("Input cannot be empty.");
            }
        }
    }
}
