public partial class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int n = digits.Length;
        digits[n - 1]++;
        for (int i = n - 1; i > 0; i--)
        {
            if (digits[i] <= 9) return digits;
            digits[i] = 0;
            digits[i - 1]++;
        }
        if (digits[0] <= 9) return digits;
        digits[0] = 0;
        return [1, .. digits];
    }
}