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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) 
    {
        List<int> tree1Values = new List<int>();
        List<int> tree2Values = new List<int>();
        recursiveSearch(root1, tree1Values);
        recursiveSearch(root2, tree2Values);
        
        return tree1Values.SequenceEqual(tree2Values);
    }

    public void recursiveSearch(TreeNode node, List<int> values)
    {
        if (node.left == null && node.right == null)
        {
            values.Add(node.val);
        }

        if (node.left != null)
        {
            recursiveSearch(node.left, values);
        }

        if (node.right != null)
        {
            recursiveSearch(node.right, values);
        }

    }
}
