namespace H___Anton_and_Danik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var s = Console.ReadLine().ToArray();
            Array.Sort(s);

            uint a = (uint)Array.IndexOf(s, 'D');
            if (a > s.Length / 2.0)
                Console.WriteLine("Anton");
            else if (a < s.Length / 2.0)
                Console.WriteLine("Danik");
            else
                Console.WriteLine("Friendship");
        }
    }
}
