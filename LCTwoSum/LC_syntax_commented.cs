An uncommented version can be found after this.

**Commented Solution**
```
'public class Solution {
    public int[] TwoSum(int[] nums, int target)
{

    //we know that all solutions have to be 2 numbers and it wants an array, so we will store it here
    int[] solution = new int[2];

    //we will iterate over each number in the provided numbers while we search
    for (int currentIndex = 0; currentIndex < nums.Length; currentIndex++)
    {

        //if we subtract the number we are currently looking at from the target sum we will get
        //the number that we are trying to find which we can add to the current number to get the target sum
        int searchTarget = target - nums[currentIndex];

        //check if the provided array has the number we are looking for AND if that number
        //is at a different index.
        //you could easily do this with another for-loop, but I like the simplicity and readability of Linq
        if (nums.Contains(searchTarget) && Array.IndexOf(nums, searchTarget) != currentIndex)
        {

            //if we found the number we need to reach the target sum, record those indexes into
            //our solution array which we created at the start, and return the result.
            solution[0] = currentIndex;
            solution[1] = Array.IndexOf(nums, searchTarget);

            //this return is not necessary here, but it significantly improves runtime since it will
            //end the for-loop immediately after finding a solution (cuts about 700ms).
            return solution;
        }
    }

    //technically this is unnecessary as well since there is guaranteed to be a solution, but 
    //it would return an empty array if there was no solution.
    return solution;
}
}
```

** Uncommented Solution**
```
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {

        int[] solution = new int[2];

        for (int currentIndex = 0; currentIndex < nums.Length; currentIndex++)
        {

            int searchTarget = target - nums[currentIndex];

            if (nums.Contains(searchTarget) && Array.IndexOf(nums, searchTarget) != currentIndex)
            {

                solution[0] = currentIndex;
                solution[1] = Array.IndexOf(nums, searchTarget);

                return solution;
            }
        }

        return solution;
    }
}
```