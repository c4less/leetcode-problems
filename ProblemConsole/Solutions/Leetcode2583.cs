public class Leetcode2583 {
    public long KthLargestLevelSum(TreeNode root, int k) {

            //BFS -level order traversing 
            //Heap using Priority Queue
            var pq = new PriorityQueue<long,long>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while(queue.Any())
            {
                long runningSum =0;
                int queueCount = queue.Count;
                for(int i=0; i< queueCount;i++)
                {
                    var eNode = queue.Dequeue();
                    runningSum+= eNode.val;

                    if(eNode.left is not null)
                        queue.Enqueue(eNode.left);
                    if(eNode.right is not null)
                        queue.Enqueue(eNode.right);
                }

                pq.Enqueue(runningSum,runningSum);
                while(pq.Count > k)
                {
                    pq.Dequeue();
                }
            }
            return pq.Count < k ? -1 : pq.Peek();
    }
}






  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 