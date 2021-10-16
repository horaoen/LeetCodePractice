/*
 * @lc app=leetcode.cn id=26 lang=csharp
 *
 * [26] 删除有序数组中的重复项
 */

// @lc code=start
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int length = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                nums[length++] = nums[i];
            }
            else if (nums[i] != nums[i - 1])
            {
                nums[length++] = nums[i];
            }
        }
        return length;
    }
}
// @lc code=end

