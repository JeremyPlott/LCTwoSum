using System;
using System.Linq;

namespace LCTwoSum
{
    class Program
    {
        static void Main(string[] args) //account for taking same number
        {
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;

            int[] solution = new int[2];

            //consider that there could be a negative for i > target
            for (int i = 0; i < nums.Length; i++)
            {

                int searchTarget = target - nums[i];

                if (nums.Contains(searchTarget) && Array.IndexOf(nums, searchTarget) != i)
                {

                    solution[0] = i;
                    solution[1] = Array.IndexOf(nums, searchTarget);

                    Console.WriteLine(solution);
                }
            }
            Console.WriteLine("failed");
        }
    }
}
