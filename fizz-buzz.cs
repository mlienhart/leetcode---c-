public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        var a = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                a.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                a.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                a.Add("Buzz");
            }
            else
            {
                a.Add(i.ToString());
            }
        }

        return a;
    }
}