public class Solution
{
    public bool RotateString(string s, string goal)
    {
        return (s + s).Contains(goal) && s.Length == goal.Length;
    }
}