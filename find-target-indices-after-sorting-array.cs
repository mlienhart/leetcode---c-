public class Solution
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        List<int> a = new List<int>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                a.Add(i);
            }
        }

        return a;
    }
}