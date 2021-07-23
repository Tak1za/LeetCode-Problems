/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
public class Solution {
    public int[] PlusOne(int[] digits) {
       for (int i=digits.Length - 1; i >= 0; i--) {
           if (digits[i] == 9) {
               digits[i] = 0;
           } else {
               digits[i] = digits[i] + 1;
               return digits;
           }
       }

       int[] result = new int[digits.Length + 1];
       result[0] = 1;
       Array.Copy(digits, 0, result, 1,digits.Length);
       return result;
    }
}
// @lc code=end

