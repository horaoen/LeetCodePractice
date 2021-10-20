/*
 * @lc app=leetcode.cn id=144 lang=csharp
 *
 * [144] 二叉树的前序遍历
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 //递归
public class Solution
{
    public List<int> res = new List<int>();
    public IList<int> PreorderTraversal(TreeNode root)
    {
        if (root == null) return res;
        res.Add(root.val);
        PreorderTraversal(root.left);
        PreorderTraversal(root.right);
        return res;
    }
}
// @lc code=end

// @lc code=start
/// <summary>
/// 栈迭代
/// </summary>
public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var res = new List<int>();
        var stack = new Stack<TreeNode>();
        while (root != null || stack.Any())
        {
            while (root != null)
            {
                res.Add(root.val);
                stack.Push(root);
                root = root.left;
            }
            root = stack.Pop();
            root = root.right;
        }
        return res;
    }
}
// @lc code=end

