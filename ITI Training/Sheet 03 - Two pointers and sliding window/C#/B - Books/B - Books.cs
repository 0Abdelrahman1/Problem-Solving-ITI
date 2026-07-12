namespace B___Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ins = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = ins[0], t = ins[1];

            int[] a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int l = 0, r = -1, ans = 0, ct = 0;
            while (l < n)
            {
                while (r + 1 < n && ct + a[r + 1] <= t) ct += a[++r];
                ans = Math.Max(ans, r - l + 1);
                ct -= a[l];
                l++;
            }

            Console.WriteLine(ans);
        }
    }
}
