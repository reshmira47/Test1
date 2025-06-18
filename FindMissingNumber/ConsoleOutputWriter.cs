namespace MissingNumberApp
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void WriteOutput(int result)
        {
            Console.WriteLine($"Missing number is: {result}");
        }
    }

}