/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */

// @lc code=start
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int i = 0;
        int j = nums.Length - 1;

        while (i <= j)
        {
            int m = i + (j - i) / 2;

            if (nums[m] == target) {
                return m;
            } else if (nums[m] < target) {
                i = m + 1;
            } else {
                j = m - 1;
            }
        }

        return i;
    }
}
// @lc code=end

