/*
 * @lc app=leetcode.cn id=189 lang=csharp
 *
 * [189] 旋转数组
 */

// @lc code=start
//我的第一次ac代码
public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int[] nums_back = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            nums_back[(i + k) % nums.Length] = nums[i];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums_back[i];
        }
    }
}


// @lc code=end

// @lc code=start
//官网题解，数组翻转
public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        Array.Reverse(nums, nums.Length - k, k);
        Array.Reverse(nums, 0, nums.Length - k);
        Array.Reverse(nums);
    }
}
// @lc code=end
