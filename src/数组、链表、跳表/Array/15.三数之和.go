/*
 * @lc app=leetcode.cn id=15 lang=golang
 *
 * [15] 三数之和
 */

// @lc code=start
func threeSum(nums []int) [][]int {
	sort.Ints(nums)
	ans := make([][]int, 0)
	for first := 0; first < len(nums) - 2; first++ {
		if first != 0 && nums[first] == nums[first-1] {
			continue
		}
		target := -nums[first]
		second, third := first + 1, len(nums) - 1
		for second < third {
			if nums[second] + nums[third] < target {
				second++
			} else if nums[second] + nums[third] > target {
				third--
			} else if second != (first + 1) && nums[second] == nums[second - 1] {
				second++
				third--
				continue
			} else {
				ans = append(ans, []int{nums[first], nums[second], nums[third]})
				second++
				third--
			}
		}
	}
	return ans
}
// @lc code=end

