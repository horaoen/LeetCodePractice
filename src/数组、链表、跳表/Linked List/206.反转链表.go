/*
 * @lc app=leetcode.cn id=206 lang=golang
 *
 * [206] 反转链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
func reverseList(head *ListNode) *ListNode {
	if head == nil || head.Next == nil {
		return head
	}
	res := reverseList(head.Next)
	head.Next.Next = head
	head.Next = nil
	return res
}
// func reverseList(head *ListNode) *ListNode {
// 	var prev *ListNode
// 	curr  := head
// 	for curr != nil {
// 		next := curr.Next
// 		curr.Next = prev
// 		prev = curr
// 		curr = next
// 	}
// 	return prev
// }
// @lc code=end

