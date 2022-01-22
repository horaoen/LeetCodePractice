/*
 * @lc app=leetcode.cn id=24 lang=golang
 *
 * [24] 两两交换链表中的节点
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
// func swapPairs(head *ListNode) *ListNode {
// 	var res *ListNode
// 	if head == nil || head.Next == nil {
//         res = head
//     } else {
//         res = head.Next
//     }
// 	pre := &ListNode{-1, head}
// 	curr := head
// 	for curr != nil && curr.Next != nil {
// 		tmp := curr.Next.Next
// 		pre.Next = curr.Next
// 		curr.Next.Next = curr
//         pre = curr
// 		curr.Next = tmp
//         curr = tmp
// 	}
// 	return res
// }
func swapPairs(head *ListNode) *ListNode {
    dummyHead := &ListNode{0, head}
    temp := dummyHead
    for temp.Next != nil && temp.Next.Next != nil {
        node1 := temp.Next
        node2 := temp.Next.Next
        temp.Next = node2
        node1.Next = node2.Next
        node2.Next = node1
        temp = node1
    }
    return dummyHead.Next
}
// @lc code=end

