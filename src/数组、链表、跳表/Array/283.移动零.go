/*
 * @lc app=leetcode.cn id=283 lang=golang
 *
 * [283] 移动零
 */

// @lc code=start
func moveZeroes(nums []int)  {
	start := 0
	for i := 0; i < len(nums); i++ {
		if(nums[i] != 0) {
			nums[start], nums[i] = nums[i], nums[start]
			start++
		}
	}
}
// @lc code=end

