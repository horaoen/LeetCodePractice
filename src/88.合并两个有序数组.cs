/*
 * @lc app=leetcode.cn id=88 lang=csharp
 *
 * [88] 合并两个有序数组
 */

// @lc code=start
//自己想的双指针写法
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] mergedNums = new int[m + n];
        int l1 = 0, l2 = 0;
        int pos = 0;
        while (l1 < m || l2 < n)
        {
            if (l1 == m)
            {
                mergedNums[pos++] = nums2[l2++];
            }
            else if (l2 == n)
            {
                mergedNums[pos++] = nums1[l1++];
            }
            else
            {
                if (nums1[l1] < nums2[l2]) mergedNums[pos++] = nums1[l1++];
                else mergedNums[pos++] = nums2[l2++];
            }
        }
        for (int i = 0; i < m + n; i++)
        {
            nums1[i] = mergedNums[i];
        }
    }
}
// @lc code=end

// @lc code=start
// 参考官方的逆行双指针写法
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int pos = m + n - 1;
        int l1 = m - 1, l2 = n - 1;
        while (l1 != -1 || l2 != -1)
        {
            if (l1 == -1) nums1[pos--] = nums2[l2--];
            else if (l2 == -1) nums1[pos--] = nums1[l1--];
            else
            {
                if (nums1[l1] >= nums2[l2])
                {
                    nums1[pos--] = nums1[l1--];
                }
                else nums1[pos--] = nums2[l2--];
            }
        }
    }
}
// @lc code=end

