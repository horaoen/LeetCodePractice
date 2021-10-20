/*
 * @lc app=leetcode.cn id=226 lang=csharp
 *
 * [226] 翻转二叉树
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
public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return root;

        var tmp = root.left;
        root.left = root.right;
        root.right = tmp;

        if (root.left != null)
        {
            InvertTree(root.left);
        }

        if (root.right != null)
        {
            InvertTree(root.right);
        }

        return root;
    }
}
// @lc code=end

// @lc code=start
public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return root;

        root.left = InvertTree(root.left);
        root.right = InvertTree(root.right);

        var tmp = root.left;
        root.left = root.right;
        root.right = tmp;

        return root;
    }
}
// @lc code=end

