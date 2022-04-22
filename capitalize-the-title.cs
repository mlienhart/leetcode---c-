public class Solution
{
    public string CapitalizeTitle(string title)
    {
        string[] a = title.ToLower().Split(' ');

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i].Length > 2)
            {
                a[i] = a[i].Substring(0, 1).ToUpper() + a[i].Substring(1);
            }
        }

        return string.Join(" ", a);
    }
}