/*
 * @lc app=leetcode.cn id=141 lang=golang
 *
 * [141] 环形链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
// func hasCycle(head *ListNode) bool {
//    if(head == nil|| head.Next == nil) return false
//    slow, fast := head, head.Next
//    while(slow != fast){
// 	   if(slow == nil || fast == nil) {
// 		   return false
// 	   }
// 	   slow = slow.Next
// 	   fast = fast.Next.Next
//    } 
//    return true
// }
func hasCycle(head *ListNode) bool {
	seen := map[*ListNode] struct{}{}
	for head != nil {
		if _, ok := seen[head]; ok {
			return true
		}
		seen[head] = struct{} {}
		head = head.Next
	}
	return false
}

// @lc code=end

