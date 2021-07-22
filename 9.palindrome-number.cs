/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) {
            return false;
        }

        var stringNum = Convert.ToString(x);
        int left = 0;
        int right = stringNum.Length - 1;

        while (left < right) {
            if (stringNum[left] == stringNum[right]) {
                left++;
                right--;
            } else {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

