// Interface
namespace MissingNumberApp
{
    // S - Single Responsibility Principle (Interface for missing number logic)
    public interface IFindMissingNumber
    {
        int FindNumberMissing(int[] nums);
    }
}