/*
 * @lc app=leetcode.cn id=142 lang=csharp
 *
 * [142] 环形链表 II
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        var seen = new HashSet<ListNode>();
        while(head != null) {
            if(seen.Contains(head)) {
                return head;
            }
            seen.Add(head);
            head = head.next;
        }
        return null;
    }
}
// @lc code=end

