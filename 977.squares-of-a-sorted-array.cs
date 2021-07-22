/*
 * @lc app=leetcode id=977 lang=csharp
 *
 * [977] Squares of a Sorted Array
 */

// @lc code=start
public class Solution {
    public int[] SortedSquares(int[] nums) {
        int size = nums.Length;
        int left = 0;
        int right = size - 1;

        int[] result = new int[size];

        for (int i=size-1; i>=0; i--) {
            if (Math.Abs(nums[right]) > Math.Abs(nums[left])) {
                result[i] = nums[right]*nums[right];
                right--;
            } else {
                result[i] = nums[left]*nums[left];
                left++;
            }
        }

        return result;
    }
}
// @lc code=end

