namespace C___Vasya_and_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Console.ReadLine().Split(' ').Select(int.Parse).ToArray() is not [var n, var k]) return;
            string s = Console.ReadLine();

            var solve = (char ch) =>
            {
                int l = 0, r = -1, ans = 0, ck = k;
                while (l < n)
                {
                    while (r + 1 < n && ck - (s[r + 1] != ch ? 1 : 0) >= 0)
                    {
                        ck -= (s[++r] != ch ? 1 : 0);
                    }
                    ans = Math.Max(ans, r - l + 1);
                    ck += (s[l] != ch ? 1 : 0);
                    l++;
                }
                return ans;
            }
            ;

            Console.WriteLine(Math.Max(solve('a'), solve('b')));
        }
    }
}
