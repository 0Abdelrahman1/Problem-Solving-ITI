using System.Numerics;

namespace J___Fence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Console.ReadLine().Split(' ').Select(long.Parse).ToArray() is not [long n, long k]) return;

            long[] a = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long l = 0, r = -1, mn = (long)1e12, i = 0, sum = 0;
            while (r + 1 < k) sum += a[++r];
            mn = sum;
            while (r + 1 < n)
            {
                sum -= a[l++];
                sum += a[++r];
                if (sum < mn)
                {
                    mn = sum;
                    i = l;
                }
            }
            Console.WriteLine(i + 1);
        }
    }
}
