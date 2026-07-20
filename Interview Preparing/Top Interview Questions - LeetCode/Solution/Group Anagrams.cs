public partial class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> clusters = new();
        int[] f;

        foreach (string str in strs)
        {
            f = new int[26];
            foreach (char c in str)
                f[c - 'a']++;
            string clusterKey = string.Join(' ', f);
            if (clusters.TryGetValue(clusterKey, out var l))
                l.Add(str);
            else
                clusters.Add(clusterKey, [str]);
        }

        return clusters.Values.Cast<IList<string>>().ToList();
    }

    public IList<IList<string>> GroupAnagrams1(string[] strs)
    {
        Dictionary<string, List<string>> clusters = new();

        foreach (string str in strs)
        {
            string clusterKey = string.Concat(str.OrderBy(c => c));

            if (clusters.TryGetValue(clusterKey, out var l))
                l.Add(str);
            else
                clusters.Add(clusterKey, [str]);
        }

        return clusters.Values.Cast<IList<string>>().ToList();
    }

    public IList<IList<string>> GroupAnagrams2(string[] strs)
    {
        Dictionary<string, List<string>> clusters = new();

        foreach (string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string clusterKey = new(chars);

            if (clusters.TryGetValue(clusterKey, out var l))
                l.Add(str);
            else
                clusters.Add(clusterKey, [str]);
        }

        return clusters.Values.Cast<IList<string>>().ToList();
    }

    public IList<IList<string>> GroupAnagrams3(string[] strs)
    {
        return strs.GroupBy(s => string.Concat(s.OrderBy(c => c)))
                   .Select(g => (IList<string>)g.ToList())
                   .ToList();
    }

    public IList<IList<string>> GroupAnagrams4(string[] strs)
    {
        Dictionary<string, List<string>> clusters = new();

        foreach (string str in strs)
        {
            char[] f = new char[26];
            foreach (char c in str) f[c - 'a']++;
            string clusterKey = new(f);

            if (!clusters.TryGetValue(clusterKey, out var l))
                l = clusters[clusterKey] = new();
            l.Add(str);
        }
        return clusters.Values.Cast<IList<string>>().ToList();
    }
}