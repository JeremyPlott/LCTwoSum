using System;
using System.Linq;

namespace LCTwoSum
{

    //could be much more efficient using a hashset or something similar
    class Program
    {
        static void Main(string[] args) //account for taking same number
        {
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;

            int[] solution = new int[2];

            //consider that there could be a negative for i > target
            for (int currentIndex = 0; currentIndex < nums.Length; currentIndex++)
            {

                int searchTarget = target - nums[currentIndex];

                if (nums.Contains(searchTarget) && Array.IndexOf(nums, searchTarget) != currentIndex)
                {

                    solution[0] = currentIndex;
                    solution[1] = Array.IndexOf(nums, searchTarget);

                    Console.WriteLine(solution);
                }
            }
            Console.WriteLine("failed");
        }
    }
}
