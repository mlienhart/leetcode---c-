public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int a = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    int b = (nums[i] - 1) * (nums[j] - 1);
                    a = Math.Max(a, b);
                }
            }
        }

        return a;
    }
}