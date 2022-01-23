/*
 * @lc app=leetcode.cn id=141 lang=csharp
 *
 * [141] 环形链表
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
// public class Solution {
//     public bool HasCycle(ListNode head) {
//        if(head == null || head.next == null){
//             return false;
//         }
//         ListNode slow = head, fast = head.next;
//         while(slow != fast){
//             if(slow == null || fast == null) return false;
//             slow = slow.next;
//             if(fast.next != null) fast = fast.next.next;
//             else return false;
//         }
//         return true;
//     }
// }
public class Solution {
    public bool HasCycle(ListNode head) {
        var seen = new HashSet<ListNode>();
        while(head != null){
            if(seen.Contains(head)) return true;
            seen.Add(head);
            head = head.next;
        }
        return false;
    }
}
// @lc code=end

