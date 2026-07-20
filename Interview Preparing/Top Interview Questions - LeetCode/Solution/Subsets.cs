public partial class Solution
{
    public IList<IList<int>> Subsets(int[] nums, int i = 1)
    {
        if (i == nums.Length + 1)
            return [[]];
        var ss = Subsets(nums, i + 1);
        int n = ss.Count;
        for (int j = 0; j < n; j++)
            ss.Add([.. ss[j], nums[^i]]);
        return ss;
    }

}
