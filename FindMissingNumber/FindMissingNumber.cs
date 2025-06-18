namespace MissingNumberApp
{
    // Concrete Implementation of 
    // D - Dependency Inversion (High-level logic depends on abstraction IMissingNumberFinder)
    public class FindMissingNumber : IFindMissingNumber
    {
        public int FindNumberMissing(int[] nums)
        {
            int n = nums.Length;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;

            foreach (int num in nums)
            {
                actualSum += num;
            }

            return expectedSum - actualSum;
        }
    }
}