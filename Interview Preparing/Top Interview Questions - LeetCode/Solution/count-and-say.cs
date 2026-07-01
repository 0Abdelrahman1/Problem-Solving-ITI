using System.Text;

public class count_and_say
{
    string RLE(string s)
    {
        StringBuilder ret = new();
        for (int i = 0, j = 0; i <= s.Length; i++)
            if (i == s.Length || s[i] != s[j])
            {
                ret.Append((i - j).ToString() + s[j]);
                j = i;
            }
        return ret.ToString();
    }

    public string CountAndSay(int n)
    {
        if (n == 1) return "1";

        return RLE(CountAndSay(n - 1));
    }

    public string CountAndSay1(int n)
    {
        if (n == 1) return "1";
        string ans = "1";
        for (int i = 1; i < n; i++)
            ans = RLE(ans);
        return ans;
    }
}
