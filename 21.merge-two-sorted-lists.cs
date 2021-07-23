/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode main = new ListNode();

        ListNode res = main;

        while (true) {
            if (l1 == null) {
                res.next = l2;
                break;
            }

            if (l2 == null) {
                res.next = l1;
                break;
            }

            if (l1.val <= l2.val) {
                res.next = l1;
                l1 = l1.next;
            } else {
                res.next = l2;
                l2 = l2.next;
            }

            res = res.next;
        }

        return main.next;
    }
}
// @lc code=end

