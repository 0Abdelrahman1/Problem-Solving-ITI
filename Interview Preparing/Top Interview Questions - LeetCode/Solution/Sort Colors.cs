public partial class Solution
{
    public void SortColors(int[] nums)
    {
        (int red, int white, int blue) c = (0, 0, 0);
        foreach (var x in nums)
            if (x == 0) c.red++;
            else if (x == 1) c.white++;
            else c.blue++;
        int i = 0;
        while (c.red-- > 0) nums[i++] = 0;
        while (c.white-- > 0) nums[i++] = 1;
        while (c.blue-- > 0) nums[i++] = 2;
    }
}
