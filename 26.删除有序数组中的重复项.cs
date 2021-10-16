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

//查看了官方题解后得到的快慢指针写法，其实跟我一开始写的一样
// @lc code=start
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int length = nums.Length;
        int fast = 0, slow = 0;
        while(fast < n) {
            if(nums[fast] != nums[slow]) 
            {
                nums[++slow] = nums[fast];
            }
            fast++;
        }
        return slow;
    }
}
// @lc code=end

