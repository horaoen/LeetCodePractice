/*
 * @lc app=leetcode.cn id=70 lang=golang
 *
 * [70] 爬楼梯
 */

// @lc code=start
func climbStairs(n int) int {
	if n <= 2 {
		return n
	}
	fx, fy := 1, 2
	for i := 3; i <= n; i++ {
		tmp := fx
		fx = fy
		fy += tmp
	}
	return fy
}
// @lc code=end

