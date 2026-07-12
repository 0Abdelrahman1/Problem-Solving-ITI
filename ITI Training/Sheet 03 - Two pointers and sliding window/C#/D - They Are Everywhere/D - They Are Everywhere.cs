namespace D___They_Are_Everywhere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), d = 0;

            string s = Console.ReadLine();
            Dictionary<char, int> f = new();
            foreach (char x in s)
            {
                if (!f.ContainsKey(x))
                    f[x] = 0;
                f[x]++;
            }
            d = f.Count;
            f.Clear();

            int l = 0, r = -1, ans = 1000_000_000, cd = 0;
            while (r < n)
            {
                if (cd == d)
                {
                    ans = Math.Min(r - l + 1, ans);
                    if ((f[s[l]] = f.GetValueOrDefault(s[l++]) - 1) == 0) cd--;
                }
                else if (r == n - 1) r++;
                else if ((f[s[++r]] = f.GetValueOrDefault(s[r]) + 1) == 1) cd++;
            }
            Console.WriteLine(ans);
        }
    }
}
