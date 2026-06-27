public class GenerateParentheses
{
    public IList<string> GenerateParenthesis(int n)
    {
        var res = new List<string>();

        void Backtrack(string s, int open, int close)
        {
            if (s.Length == n * 2) { res.Add(s); return; }
            if (open < n) Backtrack(s + "(", open + 1, close);
            if (close < open) Backtrack(s + ")", open, close + 1);
        }

        Backtrack("", 0, 0);
        return res;
    }

}
