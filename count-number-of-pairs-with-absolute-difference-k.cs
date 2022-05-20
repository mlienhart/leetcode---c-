public class Solution
{
    public int CountKDifference(int[] nums, int k)
    {
        int a = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i < j && Math.Abs(nums[i] - nums[j]) == k)
                {
                    a++;
                }
            }
        }

        return a;
    }
}