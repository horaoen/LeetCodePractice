/*
 * @lc app=leetcode.cn id=21 lang=csharp
 *
 * [21] 合并两个有序链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 //我的第一次ac代码
public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode res = new ListNode();
        ListNode pos;

        if (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                res.next = l1;
                pos = l1;
                l1 = l1.next;
            }
            else
            {
                res.next = l2;
                pos = l2;
                l2 = l2.next;
            }
        }
        else if (l2 != null)
        {
            res.next = l2;
            pos = l2;
            l2 = l2.next;
        }
        else if (l1 != null)
        {
            res.next = l1;
            pos = l1;
            l1 = l1.next;
        }
        else return l1;

        //Console.WriteLine(pos.val);

        while (l1 != null || l2 != null)
        {
            if (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    pos.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    pos.next = l2;
                    l2 = l2.next;
                }
            }
            else if (l1 == null)
            {
                pos.next = l2;
                l2 = l2.next;
            }
            else
            {
                pos.next = l1;
                l1 = l1.next;
            }
            pos = pos.next;
        }

        return res.next;
    }
}
// @lc code=end

//得知可以递归求解后

// @lc code=start
public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode choosedNode;
        if (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                choosedNode = l1;
                choosedNode.next = MergeTwoLists(l1.next, l2);
            }
            else
            {
                choosedNode = l2;
                choosedNode.next = MergeTwoLists(l1, l2.next);
            }
        }
        else if (l1 != null)
        {
            choosedNode = l1;
            choosedNode.next = MergeTwoLists(l1.next, l2);
        }
        else if (l2 != null)
        {
            choosedNode = l2;
            choosedNode.next = MergeTwoLists(l1, l2.next);
        }
        else return l1;
        return choosedNode;
    }
}
// @lc code=end


// @lc code=start
//参考官方题解后修改，更加整洁
public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 == null) return l2;
        if (l2 == null) return l1;
        if (l1.val < l2.val)
        {
            l1.next = MergeTwoLists(l1.next, l2);
            return l1;
        }
        else
        {
            l2.next = MergeTwoLists(l1, l2.next);
            return l2;
        }
    }
}
// @lc code=end
