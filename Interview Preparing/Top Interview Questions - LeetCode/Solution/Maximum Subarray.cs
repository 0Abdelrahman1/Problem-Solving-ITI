public partial class Solution
{
    public int MaxSubArray(int[] A)
    {
        (int maxPrefix, int maxSubArray, int sum, int maxSuffix) Solve(int l, int r)
        {
            if (l == r) return (A[l], A[l], A[l], A[l]);
            int mid = (l + r) >> 1;
            var L = Solve(l, mid);
            var R = Solve(mid + 1, r);
            return (Math.Max(L.maxPrefix, L.sum + R.maxPrefix), Math.Max(L.maxSubArray, Math.Max(L.maxSuffix + R.maxPrefix, R.maxSubArray)), L.sum + R.sum, Math.Max(R.maxSuffix, R.sum + L.maxSuffix));
        }
        return Solve(0, A.Length - 1).maxSubArray;
    }

    public int MaxSubArray1(int[] nums)
    {
        if (nums.Max() < 0) return nums.Max();

        int n = nums.Length;
        int[,] dp = new int[3, n + 1];

        for (int i = n - 1; i >= 0; --i)
        {
            dp[0, i] = Math.Max(dp[1, i + 1] + nums[i], dp[0, i + 1]);
            dp[1, i] = Math.Max(dp[2, i + 1], dp[1, i + 1] + nums[i]);
            dp[2, i] = dp[2, i + 1];
        }
        return dp[0, 0];
    }

    public int MaxSubArray2(int[] nums)
    {
        int sum = 0, mxsa = -100000;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            mxsa = Math.Max(mxsa, sum);
            if (sum < 0) sum = 0;
        }
        return mxsa;
    }
}
