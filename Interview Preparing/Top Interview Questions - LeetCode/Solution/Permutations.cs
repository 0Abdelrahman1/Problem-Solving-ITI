public partial class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        if (nums.Length == 0) return [[]];
        var ret = new List<IList<int>>();
        for (int i = 0; i < nums.Length; i++)
            foreach (IList<int> l in Permute([.. nums[..i], .. nums[(i + 1)..]]))
                ret.Add([nums[i], .. l]);
        return ret;
    }

    public IList<IList<int>> Permute1(int[] nums)
    {
        IList<IList<int>> ret = [];
        Array.Sort(nums);

        do ret.Add([.. nums]);
        while (next_permutation(nums));
        
        return ret;

        bool next_permutation(int[] a)
        {
            int n = a.Length, p, s;
            for (p = n - 2; p >= 0 && a[p] >= a[p + 1]; --p);

            if (p < 0) { Array.Reverse(a); return false; }

            for (s = n - 1; s >= 0 && a[p] >= a[s]; --s);

            (a[p], a[s]) = (a[s], a[p]);
            Array.Reverse(a, p + 1, n - p - 1);
            return true;
        }
    }
}
