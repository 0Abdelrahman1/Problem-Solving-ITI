namespace F___Petya_and_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = new (Console.ReadLine().Select(char.ToLower).ToArray()),
                b = new (Console.ReadLine().Select(char.ToLower).ToArray());

            Console.WriteLine(a.CompareTo(b));
        }
    }
}
