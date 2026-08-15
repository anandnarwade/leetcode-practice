using problem.app._1._Two_Sum;

namespace problem.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            TwoSum twoSum = new TwoSum();
            int[] result = twoSum.Find(nums, target);
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }
    }
}
