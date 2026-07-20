public partial class Solution
{
    public int NumDecodings(string s)
    {
        int[] dp = new int[s.Length + 1];
        dp[^1] = 1;
        dp[^2] = s[^1] == '0' ? 0 : 1;

        for (int i = s.Length - 2; i >= 0; i--)
            if (s[i] == '0')
                dp[i] = 0;
            else if (int.Parse(s[i..(i + 2)]) <= 26)
                dp[i] = dp[i + 2] + dp[i + 1];
            else
                dp[i] = dp[i + 1];
        return dp[0];
    }
}