using System.Numerics;

namespace I___Vanya_and_Fence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Console.ReadLine().Split(' ').Select(int.Parse).ToArray() is not [var n, var h]) return;
            int ans = 0;
            foreach (var x in Console.ReadLine().Split(' ').Select(int.Parse))
                if (x > h)
                    ans += 2;
                else
                    ans++;
            Console.WriteLine(ans);
        }
    }
}
