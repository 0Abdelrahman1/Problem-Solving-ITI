namespace A___Sereja_and_Dima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            LinkedList<int> d = new();
            foreach (var x in Console.ReadLine().Split(" ").Select(x => int.Parse(x)))
                d.AddLast(x);

            int[] s = new int[2];
            for (int i = 0; d.Count > 0; i++, i %= 2)
            {
                if (d.First.Value > d.Last.Value)
                {
                    s[i] += d.First.Value;
                    d.RemoveFirst();
                }
                else
                {
                    s[i] += d.Last.Value;
                    d.RemoveLast();
                }
            }
            Console.WriteLine($"{s[0]} {s[1]}");
        }
    }
}
