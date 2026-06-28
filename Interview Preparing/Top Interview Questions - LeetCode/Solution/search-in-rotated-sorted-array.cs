
public class search_in_rotated_sorted_array
{
    public int Search(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1, mid;
        while (l <= r)
        {
            mid = l + r >> 1;
            if (nums[mid] == target)
                return mid;
            else if (target <= nums[^1]) // tr
                if (nums[mid] <= nums[^1]) // mr
                    if (target < nums[mid])
                        r = mid - 1;
                    else
                        l = mid + 1;
                else                       // ml
                    l = mid + 1;
            else                          // tl
                if (nums[mid] >= nums[0]) // ml
                    if (target < nums[mid])
                        r = mid - 1;
                    else
                        l = mid + 1;
                else                      // mr
                    r = mid - 1;
        }
        return -1;
    }
}
