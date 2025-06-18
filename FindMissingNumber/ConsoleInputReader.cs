using System;
namespace MissingNumberApp
{
    // O - InputReader can be extended for other sources  like file or API 
    public class ConsoleInputReader : IInputReader
    {
        public int[] ReadInput()
        {
            int[] nums = Array.Empty<int>();
            // --- Read number array safely ---
            while (true)
            {
                Console.WriteLine("Enter the numbers separated by commas (e.g., 3,0,1):");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    continue;
                }

                try
                {
                    nums = input.Split(',')
                                .Select(s => int.Parse(s.Trim()))
                                .ToArray();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter only integers separated by commas.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
            return nums;
        }
    }
}