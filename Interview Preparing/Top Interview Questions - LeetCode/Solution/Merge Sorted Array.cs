public class Merge_Sorted_Array
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = m - 1; i >= 0; i--)
            nums1[i + n] = nums1[i];
        for (int i = n, j = 0, k = 0; k < nums1.Length; k++)
            if (j == nums2.Length)
                nums1[k] = nums1[i++];
            else if (i == nums1.Length)
                nums1[k] = nums2[j++];
            else
                nums1[k] = nums1[i] < nums2[j] ? nums1[i++] : nums2[j++];
    }
}
