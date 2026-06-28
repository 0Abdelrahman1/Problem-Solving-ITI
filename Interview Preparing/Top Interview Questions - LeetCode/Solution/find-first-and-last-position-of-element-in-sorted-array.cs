public class find_first_and_last_position_of_element_in_sorted_array
{
    public int[] SearchRange(int[] nums, int target)
    {
        if (nums.Length == 0) return [-1, -1];
        int upper_bound(int target)
        {
            int l = 0, r = nums.Length, mid, ans = -1;
            while (l <= r)
            {
                mid = l + r >> 1;
                if (mid == nums.Length || nums[mid] > target) { ans = mid; r = mid - 1; }
                else
                    l = mid + 1;
            }
            return ans;
        }

        int l = upper_bound(target - 1);
        int r = upper_bound(target);

        if (l == r || nums[l] != target)
            return [-1, -1];
        else
            return [l, r - 1];
    }
}
