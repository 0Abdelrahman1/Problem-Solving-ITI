public partial class Solution
{
    public int UniquePaths(int m, int n)
    {
        if (n > m) (n, m) = (m, n);
        long Ck = 1;
        for (int i = 1; i < n; i++)
            Ck = Ck * (n + m - i - 1) / i;
        return (int)Ck;
    }
}
