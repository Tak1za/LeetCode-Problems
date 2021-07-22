/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (Array.IndexOf(strs, "") != -1) {
            return "";
        }

        string res = strs[0];
        int size = res.Length;

        foreach(string word in strs) {
            int i = 0;
            foreach(char c in word) {
                if (i >= size || res[i] != c) {
                    break;
                }
                i++;
            }
            size = Math.Min(size, i);
        }

        return res.Substring(0, size);
    }
}
// @lc code=end

