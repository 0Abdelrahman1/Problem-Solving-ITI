public partial class Solution
{
    public int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle);
    }

    public int StrStr1(string haystack, string needle)
    {
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
            if (haystack[i..(i + needle.Length)].Equals(needle))
                return i;
        return -1;
    }

    public int StrStr2(string haystack, string needle)
    {
        for (int i = 0, j; i <= haystack.Length - needle.Length; i++)
        {
            for (j = 0; j < needle.Length; j++)
                if (haystack[i + j] != needle[j]) break;
            if (j == needle.Length)
                return i;
        }
        return -1;
    }

    public int StrStr3(string haystack, string needle)
    {
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
            if (haystack.Substring(i, needle.Length).Equals(needle))
                return i;
        return -1;
    }
}
