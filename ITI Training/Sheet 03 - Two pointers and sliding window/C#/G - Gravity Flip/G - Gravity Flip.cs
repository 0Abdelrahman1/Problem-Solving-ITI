using System.Numerics;

namespace G___Gravity_Flip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(a);
            Console.WriteLine(string.Join(" ", a));
        }
    }
}
