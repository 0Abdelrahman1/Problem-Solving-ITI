using System.Text;

public class Wildcard_Matching
{
    public bool IsMatch(string s, string p)
    {
        int IndexOf(string s, string p, int i)
        {
            for (int j = i; j <= s.Length - p.Length; j++)
            {
                bool ok = true;
                for (int k = 0; k < p.Length; k++)
                    if (s[j + k] != p[k] && p[k] != '?')
                    {
                        ok = false;
                        break;
                    }
                if (ok)
                    return j;
            }
            return -1;
        }
        bool IsMatch(string s, string p, int i, int j)
        {
            if (i == s.Length && j == p.Length) return true;
            if (i == s.Length) return p[j..] == new string('*', p.Length - j);
            if (j == p.Length) return true;

            if (p[j] == '*') return IsMatch(s, p, i, j + 1);

            int lp = p.IndexOfAny(['*'], j);
            int ss = IndexOf(s, p[j..lp], i);
            if (ss == -1) return false;
            return IsMatch(s, p, ss + lp - j, lp);
        }

        int i = 0, j = 0;
        while (i < s.Length)
        {
            if (j == p.Length || s[i] != p[j] && p[j] != '?' && p[j] != '*')
                return false;
            if (p[j] == '*') break;
            i++; j++;
        }

        int ii = s.Length - 1, jj = p.Length - 1;
        while (ii >= i)
        {
            if (jj == -1 || s[ii] != p[jj] && p[jj] != '?' && p[jj] != '*')
                return false;
            if (p[jj] == '*') break;
            ii--; jj--;
        }
        return IsMatch(s[i..(ii + 1)], p[j..(jj + 1)], 0, 0);
    }

    public bool IsMatch1(string s, string p)
    {
        int n = s.Length, m = p.Length;

        bool[,] dp = new bool[n + 1, m + 1];
        dp[n, m] = true;
        for (int j = m - 1; j >= 0; j--)
            dp[n, j] = dp[n, j + 1] && p[j] == '*';

        for (int i = n - 1; i >= 0; --i)
            for (int j = m - 1; j >= 0; --j)
                if (s[i] == p[j] || p[j] == '?')
                    dp[i, j] = dp[i + 1, j + 1];
                else if (p[j] == '*')
                    dp[i, j] = dp[i, j + 1] | dp[i + 1, j];
        return dp[0, 0];
    }

    public bool IsMatch2(string s, string p)
    {
        int n = s.Length, m = p.Length;
        p = p + "0";

        int i = 0, j = 0, ii = 0, star = -1;

        while (i < n)
        {
            if (s[i] == p[j] || p[j] == '?') { i++; j++; }
            else if (p[j] == '*') { ii = i; star = j++; }
            else if (star > -1) { i = ++ii; j = star + 1;  }
            return false;
        }

        while (j < m)
            if (p[j++] != '*')
                return false;
        return true;
    }

}
