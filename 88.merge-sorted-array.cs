/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int index = m+n-1;
        m--;
        n--;

        while (m >= 0 && n >= 0) {
            if (nums1[m] > nums2[n]) {
                nums1[index] = nums1[m];
                m--;
            } else {
                nums1[index] = nums2[n];
                n--;
            }
            index--;
        }

        if (n < 0) {
            return;
        }

        while (n >= 0) {
            nums1[index] = nums2[n];
            index--;
            n--;
        }
    }
}
// @lc code=end

