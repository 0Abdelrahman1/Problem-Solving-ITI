public class Minimum_Window_Substring
{
    public string MinWindow(string s, string t)
    {
        if (s.Length < t.Length) return "";
        int[] F = new int['z' + 2];
        foreach (var c in t) { F[c]++; F[^1]++; }

        (int mn, int l) mws = (int.MaxValue, -1);
        int i = 0, j = -1;
        while (i < s.Length)
        {
            while (F[^1] != 0 && j + 1 < s.Length) if (--F[s[++j]] >= 0) F[^1]--;
            var nw = (j - i + 1, i);
            if (F[^1] == 0) mws = mws.CompareTo(nw) <= 0 ? mws : nw;
            if (++F[s[i]] > 0) F[^1]++;
            i++;
        }
        if (mws.l == -1) return "";
        return s[mws.l..(mws.l + mws.mn)];
    }
}
