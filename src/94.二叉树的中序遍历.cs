/*
 * @lc app=leetcode.cn id=94 lang=csharp
 *
 * [94] 二叉树的中序遍历
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
//递归写法
public class Solution
{
    public List<int> res = new List<int>();
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null) return res;
        InorderTraversal(root.left);
        res.Add(root.val);
        InorderTraversal(root.right);
        return res;
    }
}
// @lc code=end

// @lc code=start
/// <summary>
/// 栈迭代
/// 递归的时候隐式地维护了一个栈，而我们在迭代的时候需要显式地将这个栈模拟出来
/// </summary>
public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var res = new List<int>();
        var stack = new Stack<TreeNode>();
        while(root != null  || stack.Any()) 
        {
            while(root != null)
             {
                stack.Push(root);
                root = root.left;
            }
            root = stack.Pop();
            res.Add(root.val);
            root = root.right;
        }
        return res;
    }
}
// @lc code=end

