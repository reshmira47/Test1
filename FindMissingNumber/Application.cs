// Application orchestrator
namespace MissingNumberApp
{
    public class Application
    {
        private readonly IFindMissingNumber _finder;

        public Application(IFindMissingNumber finder)
        {
            _finder = finder;
        }

        public void Run()
        {
            IInputReader reader = new ConsoleInputReader();
            IFindMissingNumber finder = new FindMissingNumber();
            IOutputWriter writer = new ConsoleOutputWriter();

            int[] nums = reader.ReadInput();
            int missingNumber = finder.FindNumberMissing(nums);
            writer.WriteOutput(missingNumber);
        }
    }
}