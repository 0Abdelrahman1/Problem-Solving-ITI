using System.Numerics;

class Sqrt_x_
{
    public int MySqrt(int x)
    {
        int l = 0, r = x, mid, ans = -1;
        while (l <= r)
        {
            mid = l + r >> 1;
            if (1l * mid * mid > x)
                r = mid - 1;
            else
            {
                l = mid + 1;
                ans = mid;
            }
        }
        return ans;
    }

    public int MySqrt1(int x)
    {
        int b = BitOperations.Log2((uint)x); // for counting min bits needed

        int ans = 0;
        for (int i = b / 2; i >= 0; --i)
        {
            ans |= 1 << i;
            if (1l * ans * ans > x)
                ans ^= 1 << i;
        }
        return ans;
    }
}
