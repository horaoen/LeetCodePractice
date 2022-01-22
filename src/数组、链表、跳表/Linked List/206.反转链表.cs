/*
 * @lc app=leetcode.cn id=206 lang=csharp
 *
 * [206] 反转链表
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
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null){
            return head;
        }
        var res = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return res;
    }
}
// public class Solution {
//     public ListNode ReverseList(ListNode head) {
//         ListNode prev = null;
//         var curr = head;
//         while(curr != null) {
//             var next = curr.next;
//             curr.next = prev;
//             prev = curr;
//             curr = next;
//         }
//         return prev;
//     }
// }
// @lc code=end

