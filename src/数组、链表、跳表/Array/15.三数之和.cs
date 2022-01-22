/*
 * @lc app=leetcode.cn id=15 lang=csharp
 *
 * [15] 三数之和
 */

// @lc code=start
public class Solution 
{
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        var res = new List<IList<int>>();
        Array.Sort(nums);
        for (int first = 0; first < nums.Length - 2; first++) 
        {
            if(first != 0 && nums[first] == nums[first - 1]) continue;
            var target = -nums[first];
            int second = first + 1, third = nums.Length - 1;
            while(second < third)
            {
                if(nums[second] + nums[third] < target) second++;
                else if(nums[second] + nums[third] > target) third--;
                else if(nums[second] == nums[second - 1] && second != first + 1) 
                {
                    second++;
                    third--;
                    continue;
                } 
                else
                {
                    res.Add(new List<int>() { nums[first], nums[second], nums[third] });
                    second++;
                    third--;
                }
            }
        }
        return res;
    }
}
// @lc code=end

