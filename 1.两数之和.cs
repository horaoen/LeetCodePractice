/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
//暴力枚举，hash解法在hash表章节展示
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] res = new int[2];
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    res[0] = i;
                    res[1] = j;
                    return res;
                }
            }
        }
        return res;
    }
}
// @lc code=end

