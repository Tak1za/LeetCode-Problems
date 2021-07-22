/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Hashtable hashtable = new Hashtable();
        for(int i=0; i<nums.Length; i++) {
            int val = target - nums[i];
            if (hashtable.ContainsKey(val)) {
                return new int[]{i, (int)hashtable[val]};
            } else if (!hashtable.ContainsKey(nums[i])) {
                hashtable.Add(nums[i], i);
            }
        }

        return new int[2];
    }
}
// @lc code=end

