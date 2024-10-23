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
public class Leetcode2641 {
    public TreeNode ReplaceValueInTree(TreeNode root) {
        
        //BFs Approach
        Queue<TreeNode> queue = new();
        List<int> levelSumList = new();

        queue.Enqueue(root);
        while(queue.Any())
        {
            int currSum =0;
            int queueLength = queue.Count;

            for(int i=0; i< queueLength; i++)
            {
                var eNode = queue.Dequeue();
                currSum+= eNode.val;

                if(eNode.left is not null)
                    queue.Enqueue(eNode.left);
                if(eNode.right is not null)
                    queue.Enqueue(eNode.right);

            }
            levelSumList.Add(currSum);
        }

        Queue<(TreeNode node, int val)> queue2= new();
        int level =0;
        queue2.Enqueue((root, root.val));
        
        while(queue2.Any())
        {
            int queue2Length = queue2.Count;
            for(int i=0; i< queue2Length; i++)
            {
                (var eNode, var value) = queue2.Dequeue();
                eNode.val = levelSumList[level] - value;

                int currSum =0;
                if(eNode.left is not null)
                    currSum+= eNode.left.val;
                if(eNode.right is not null)
                    currSum+= eNode.right.val;

                if(eNode.left is not null)
                    queue2.Enqueue((eNode.left,currSum));
                
                if(eNode.right is not null)
                    queue2.Enqueue((eNode.right,currSum));
            }
            level+=1;

        }
        return root;
    }
}