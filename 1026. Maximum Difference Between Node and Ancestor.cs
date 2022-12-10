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
public class Solution {
    
    int result = 0;

    public int MaxAncestorDiff(TreeNode root) 
    {
        recursiveSearch(root, root.val, root.val);
        return result;
    }

    public void recursiveSearch(TreeNode node, int max, int min)
    {
        // base case: empty node
        if (node == null) return;

        // update result
        result = Math.Max(result, Math.Max(Math.Abs(min - node.val), Math.Abs(max - node.val)));   
        
        // update min and max
        max = Math.Max(max, node.val);
        min = Math.Min(min, node.val);

        // Recursion
        recursiveSearch(node.right, max, min);
        recursiveSearch(node.left, max, min);
    }
}
