/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 */

// @lc code=start
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        int[] count = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
        }
        for (int i = 0; i < t.Length; i++)
        {
            if (count[t[i] - 'a'] == 0) return false;
            else count[t[i] - 'a']--;
        }
        return true;
    }

}
// @lc code=end

