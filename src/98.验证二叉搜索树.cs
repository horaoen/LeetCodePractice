/*
 * @lc app=leetcode.cn id=98 lang=csharp
 *
 * [98] 验证二叉搜索树
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
 //直接递归逐层判断
public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        return Helper(root, Int64.MaxValue, Int64.MinValue);
    }

    public bool Helper(TreeNode root, Int64 upper, Int64 lowwer)
    {
        if (root == null) return true;

        bool res = Helper(root.left, root.val, lowwer) && Helper(root.right, upper, root.val);
        if (res == false) return false;

        if (root.val > lowwer && root.val < upper) return true;
        return false;
    }
}
// @lc code=end

// @lc code=start
//中序遍历
public class Solution
{

    public List<int> BST = new List<int>();
    public bool IsValidBST(TreeNode root)
    {
        InOrderTraversal(root);
        var bst = BST.ToArray();
        for (int i = 1; i < bst.Length; i++)
        {
            if (bst[i] <= bst[i - 1]) return false;
        }
        return true;
    }

    public void InOrderTraversal(TreeNode root)
    {
        if (root == null) return;

        InOrderTraversal(root.left);
        BST.Add(root.val);
        InOrderTraversal(root.right);
    }
}
// @lc code=end

