/*
 * @lc app=leetcode id=28 lang=csharp
 *
 * [28] Implement strStr()
 */

// @lc code=start
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle))
        {
            return 0;
        }

        if (string.IsNullOrEmpty(haystack) && string.IsNullOrEmpty(needle))
        {
            return -1;
        }

        if (needle.Length > haystack.Length)
        {
            return -1;
        }

        int i = 0;
        while (i <= (haystack.Length - needle.Length))
        {
            if (string.Equals(haystack.Substring(i, needle.Length), needle))
            {
                return i;
            }
            i++;
        }

        return -1;
    }
}
// @lc code=end

