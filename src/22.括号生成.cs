/*
 * @lc app=leetcode.cn id=22 lang=csharp
 *
 * [22] 括号生成
 */

// @lc code=start
public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var res = new List<string>();
        Generate(0, 0, n, new StringBuilder(), res);
        return res;
    }

    public void Generate(int left, int right, int n, StringBuilder s, List<string> res)
    {
        if (left == n && right == n)
        {
            res.Add(s.ToString());
            return;
        }

        if (left < n)
        {
            s.Append("(");
            Generate(left + 1, right, n, s, res);
            s.Remove(s.Length - 1, 1);
        }

        if (right < left)
        {
            s.Append(")");
            Generate(left, right + 1, n, s, res);
            s.Remove(s.Length - 1, 1);
        }
    }
}
// @lc code=end

