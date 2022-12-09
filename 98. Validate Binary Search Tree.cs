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
    public bool IsValidBST(TreeNode root) 
    {
        return recursiveSearch(root, null, null); 
    }

    public bool recursiveSearch(TreeNode node, int? lowerlimit, int? upperlimit)
    {
        // empty : valid by default
        if (node == null)
        {
            return true; 
        }

        if ( (lowerlimit != null && node.val <= lowerlimit) || (upperlimit != null && node.val >= upperlimit) )
        {
            return false;
        }

        return recursiveSearch(node.left, lowerlimit, node.val) && recursiveSearch(node.right, node.val, upperlimit);
    }
}
