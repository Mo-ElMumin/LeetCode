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
    
    public int RangeSumBST(TreeNode root, int low, int high) 
    {
        recursiveSearch(root, low, high);
        return result;
    }

    public void recursiveSearch(TreeNode root, int low, int high)
    {
        if (low <= root.val && root.val <= high)
        {
            result = result + root.val;
        }

        if (root.left != null)
        {
            recursiveSearch(root.left, low, high);
        }
        
        if (root.right != null)
        {
            recursiveSearch(root.right, low, high);
        }
    }   
    
}
