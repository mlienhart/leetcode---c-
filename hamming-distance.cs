public class Solution
{
    public int HammingDistance(int x, int y)
    {
        string a = Convert.ToString(x, 2);
        string b = Convert.ToString(y, 2);
        int c = 0;
        char d = '0';

        if (a.Length < b.Length)
        {
            a = a.PadLeft(b.Length, d);
        }

        if (a.Length > b.Length)
        {
            b = b.PadLeft(a.Length, d);
        }

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                c++;
            }
        }

        return c;
    }
}