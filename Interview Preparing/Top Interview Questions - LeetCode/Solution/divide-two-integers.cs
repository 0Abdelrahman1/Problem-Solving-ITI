public partial class Solution
{
    public int Divide(int dividend, int divisor)
    {
        return (int) Math.Min(1L * dividend / divisor, int.MaxValue);
    }

    public int Divide1(int dd, int d)
    {
        long dividend = dd;
        long divisor = d;
        long ans = 0, w = 1;
        while (w * 10 <= dividend)
            w *= 10;
        bool sign = (dividend < 0) ^ (divisor < 0);
        dividend = Math.Abs(dividend);
        divisor = Math.Abs(divisor);
        while (w > 0)
        {
            long x = dividend / w / divisor * w;
            dividend -= (divisor * x);
            ans += x;
            w /= 10;
        }

        if (sign)
            ans = Math.Max(ans * -1, int.MinValue);
        else
            ans = Math.Min(ans, int.MaxValue);

        return (int)ans;
    }

    // This Solution Learned from "https://leetcode.com/problems/divide-two-integers/solutions/142849/cjavapython-should-not-use-long-int-by-l-bb5h"
    public int Divide2(int dividend, int divisor)
    {
        if (dividend == int.MinValue)
            if (divisor == -1)
                return int.MaxValue;
            else if (divisor < 0)
                return Divide2(dividend - divisor, divisor) + 1;
            else
                return Divide2(dividend + divisor, divisor) - 1;
        else if (divisor == int.MinValue)
            return 0;

        int dd = Math.Abs(dividend), d = Math.Abs(divisor), ans = 0;

        for (int b = 31; b >= 0; b--)
            if ((dd >> b) - d >= 0)
            {
                ans += 1 << b;
                dd -= d << b;
            }

        return dividend < 0 ^ divisor < 0 ? -ans : ans;
    }
}
