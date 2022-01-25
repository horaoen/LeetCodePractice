/*
 * @lc app=leetcode.cn id=25 lang=csharp
 *
 * [25] K 个一组翻转链表
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
    public ListNode ReverseKGroup(ListNode head, int k) {
        var hair = new ListNode { next = head };
        var pre = hair;
        while(head != null) {
            var tail = pre;
            for (int i = 0; i < k; i++) {
                if(tail.next == null) {
                    return hair.next;
                }
                tail = tail.next;
            }
            var nex = tail.next;
            var res = ReverseList(head, tail);
            head = res[0];
            tail = res[1];
            pre.next = head;
            tail.next = nex;
            pre = tail;
            head = tail.next;
        }
        return hair.next;
    }
    public List<ListNode> ReverseList(ListNode head, ListNode tail) {
        if(head == tail) {
            return new List<ListNode> { head, head };
        }
        var res = ReverseList(head.next, tail);
        res[1].next = head;
        head.next = null;

        return new List<ListNode> {res[0], head};
    }
}
// @lc code=end

