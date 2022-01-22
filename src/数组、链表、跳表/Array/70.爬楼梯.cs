/*
 * @lc app=leetcode.cn id=70 lang=csharp
 *
 * [70] 爬楼梯
 */

// @lc code=start
public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 2) return n;
        int fa = 1, fb = 2;
        for (int i = 3; i <= n; i++)
        {
            int tmp = fa + fb;
            fa = fb;
            fb = tmp;
        }
        return fb;
    }
}
// @lc code=end

// @lc code=start
public class Solution
{
    public int[] step = new int[100];
    public int ClimbStairs(int n)
    {
        if (step[n] != 0) return step[n];
        if (n <= 2) return n;
        step[n - 1] = ClimbStairs(n - 1);
        step[n - 2] = ClimbStairs(n - 2);
        return step[n - 1] + step[n - 2];
    }
}
// @lc code=end
