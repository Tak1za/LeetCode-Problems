/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution
{
    public int RomanToInt(string s)
    {
        int result = 0;
        for (int i=0; i<s.Length; i++) {
            switch (s[i]) {
                case 'M':
                    result += 1000;
                    break;
                case 'D':
                    result += 500;
                    break;
                case 'C':
                    result += 100;
                    break;
                case 'L':
                    result += 50;
                    break;
                case 'X':
                    result += 10;
                    break;
                case 'V':
                    result += 5;
                    break;
                case 'I':
                    result += 1;
                    break;
            }
        }

        if (s.Contains("CD") || s.Contains("CM")) {
            result -= 200;
        }
        if (s.Contains("XL") || s.Contains("XC")) {
            result -= 20;
        }
        if (s.Contains("IV") || s.Contains("IX")) {
            result -= 2;
        }

        return result;
    }
}
// @lc code=end

