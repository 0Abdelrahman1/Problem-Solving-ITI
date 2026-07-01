public class Trapping_Rain_Water
{
    public int Trap(int[] height)
    {
        int max = int.MinValue;
        int[] lmx = height.Select(x => max = Math.Max(max, x)).ToArray();
        max = int.MinValue;
        int[] rmx = height.Reverse().Select(x => max = Math.Max(max, x)).Reverse().ToArray();

        int ans = 0;
        for (int i = 0; i < height.Length; i++)
            ans += Math.Min(lmx[i], rmx[i]) - height[i];
        return ans;
    }

    public int Trap1(int[] height)
    {
        int n = height.Length;
        int max = int.MinValue;
        int[] rmx = new int[n];
        for (int i = n - 1; i >= 0; i--)
            rmx[i] = max = Math.Max(max, height[i]);

        max = int.MinValue;
        int ans = 0;
        for (int i = 0; i < height.Length; i++)
        {
            max = Math.Max(max, height[i]);
            ans += Math.Min(rmx[i], max) - height[i];
        }
        return ans;
    }
}
