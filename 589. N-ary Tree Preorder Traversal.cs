/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
 

    public IList<int> Preorder(Node root) 
    {
        if (root == null)
        {
            return new List<int>();
        }

        List<int> values = new List<int>();
        recursiveSearch(root, values);
        return values;
    }

    public void recursiveSearch(Node root, List<int> values)
    {
        values.Add(root.val);
        if (root.children != null) // i.e. has children
        {
            for( int i = 0; i < root.children.Count; i++)
            {
                recursiveSearch(root.children[i], values);
            }
        }
    }

}
