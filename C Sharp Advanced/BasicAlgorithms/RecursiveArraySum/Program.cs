using System;
using System.Linq;

namespace RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            Console.WriteLine(Sum(nums, 0));
        }

        static int Sum(int[] nums, int index)
        {
            if (index == nums.Length)
            {
                return 0;
            }
            int result = Sum(nums, index + 1);
            return nums[index] + result;
        }
    }
}
