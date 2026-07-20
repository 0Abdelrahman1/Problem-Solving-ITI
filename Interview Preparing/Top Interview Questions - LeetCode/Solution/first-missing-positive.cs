public partial class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        foreach (ref var x in nums.AsSpan())
            if (x < 0)
                x = 0;

        for (int i = 0; i < nums.Length; i++)
            while (nums[i] > 0 && nums[i] <= nums.Length)
            {
                ref int tmp = ref nums[nums[i] - 1];
                nums[i] = Math.Max(tmp, 0);
                tmp = -1;
            }

        for (int i = 0; i < nums.Length; ++i)
            if (nums[i] != -1)
                return i + 1;
        return nums.Length + 1;
    }

    public int FirstMissingPositive1(int[] nums)
    {
        nums = nums.Select(x => Math.Max(x, 0)).ToArray();

        foreach (var x in nums) Console.WriteLine(x);
        for (int i = 0; i < nums.Length; i++)
            while (nums[i] > 0 && nums[i] <= nums.Length)
            {
                int tmp = nums[nums[i] - 1];
                nums[nums[i] - 1] = -1;
                nums[i] = Math.Max(tmp, 0);
            }

        for (int i = 0; i < nums.Length; ++i)
            if (nums[i] != -1)
                return i + 1;
        return nums.Length + 1;
    }
    public int FirstMissingPositive2(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
            while (nums[i] > 0 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i])
                (nums[i], nums[nums[i] - 1]) = (nums[nums[i] - 1], nums[i]);

        for (int i = 0; i < nums.Length; ++i)
            if (nums[i] != i + 1)
                return i + 1;
        return nums.Length + 1;
    }

}
