/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
public class Solution {
    public int Reverse(int x) {
        int sign = Math.Sign(x);

        var digits = new List<int>();

        while (x != 0) {
            int digit = x % 10;
            x = x - digit;
            digits.Add(digit);
            x = x / 10;
        }

        int count = digits.Count;

        double result = 0;

        for (int i=0; i<count; i++) {
            result += Math.Pow(10, count - i - 1) * digits[i];
        }

        result = Math.Abs(result);

        return result > int.MaxValue ? 0 : sign * (int)result;
    }
}
// @lc code=end

