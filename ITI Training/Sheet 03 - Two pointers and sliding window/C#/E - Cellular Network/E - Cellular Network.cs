namespace E___Cellular_Network
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Console.ReadLine().Split(' ').Select(long.Parse).ToArray() is not [ var n, var m ]) return;
            
            List<long> a = new(Console.ReadLine().Split(' ').Select(long.Parse)),
                b = new(Console.ReadLine().Split(' ').Select(long.Parse));
            b.Add((long)-1e15);
            b.Add((long)1e15);
            a.Sort();
            b.Sort();

            int i = 0, j = -1;
            long ans = 0;
            while (i < n)
            {
                while (j + 1 < m + 2 && b[j + 1] <= a[i]) j++;
                ans = Math.Max(ans, Math.Min(a[i] - b[j], b[j + 1] - a[i]));
                i++;
            }
            Console.WriteLine(ans);
        }
    }
}
