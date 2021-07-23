/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 */

// @lc code=start
public class Solution {
    public int LengthOfLastWord(string s) {
        int len = 0;
        for(int i=s.Length - 1; i >= 0; i--) {
            if (s[i] != ' ') {
                len++;
            } else {
                if (len == 0) {
                    continue;
                } else {
                    return len;
                }
            }
        }

        return len;
    }
}
// @lc code=end

