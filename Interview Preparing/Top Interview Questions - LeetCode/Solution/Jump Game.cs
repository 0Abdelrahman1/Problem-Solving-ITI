public partial class Solution
{
    public bool CanJump(int[] nums)
    {
        int j = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--)
            if (nums[i] >= j - i)
                j = i;
        return j == 0;
    }
}
