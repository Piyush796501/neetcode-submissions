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
    public TreeNode InvertTree(TreeNode root) {
        if(root==null)
         return null;
        Queue<TreeNode> treeNodeLst=new Queue<TreeNode>();
        treeNodeLst.Enqueue(root);
        while(treeNodeLst.Count>0)
        {
            TreeNode node=treeNodeLst.Dequeue();
            TreeNode temp=node.left;
            node.left=node.right;
            node.right=temp;
            if(node.left!=null)
              treeNodeLst.Enqueue(node.left);
            if(node.right!=null)
               treeNodeLst.Enqueue(node.right);
        }
        return root;
        
    }
}
