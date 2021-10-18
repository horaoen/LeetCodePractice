/*
 * @lc app=leetcode.cn id=49 lang=csharp
 *
 * [49] 字母异位词分组
 */

// @lc code=start
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {

        var dic = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            char[] s = strs[i].ToArray();
            Array.Sort(s);
            string str = new String(s);
            if (dic.ContainsKey(str)) dic[str].Add(strs[i]);
            else
            {
                var initValue = new List<string>();
                initValue.Add(strs[i]);
                dic.Add(str, initValue);
            }
        }

        var res = new List<IList<string>>();
        foreach (var kvp in dic)
        {
            res.Add(kvp.Value);
        }
        return res;
    }
}
// @lc code=end

