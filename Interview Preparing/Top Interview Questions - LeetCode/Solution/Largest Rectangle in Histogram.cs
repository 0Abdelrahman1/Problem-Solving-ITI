public partial class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        heights = [.. heights, -1];
        int n = heights.Length, ans = 0;
        Stack<int> MMS = new([-1]);
        for (int i = 0; i < n; i++)
        {
            while (MMS.Peek() != -1 && heights[MMS.Peek()] >= heights[i])
            {
                int h = heights[MMS.Pop()];
                ans = Math.Max(ans, (i - MMS.Peek() - 1) * h);
            }
            MMS.Push(i);
        }
        return ans;
    }
    public int LargestRectangleArea1(int[] heights)
    {
        int n = heights.Length;
        int[] ha = new int[n];
        Stack<(int value, int index)> MMS = new([(-1, -1)]);
        for (int i = 0; i < n; i++)
        {
            while (MMS.Peek().value >= heights[i]) MMS.Pop();
            ha[i] = heights[i] * -MMS.Peek().index;
            MMS.Push((heights[i], i));
        }
        MMS.Clear();
        MMS.Push((-1, n - 1));
        int ans = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            while (MMS.Peek().value >= heights[i]) MMS.Pop();
            ha[i] += heights[i] * MMS.Peek().index;
            ans = Math.Max(ans, ha[i]);
            MMS.Push((heights[i], i - 1));
        }
        return ans;
    }
}