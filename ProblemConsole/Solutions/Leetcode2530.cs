//Time : O(n Log N) + O(k Log N)
//Space: O(n)

public class LeetCode2530 {
    public long MaxKelements(int[] nums, int k) {
        long maxResult =0;
        var pq = new PriorityQueue<long,long>(Comparer<long>.Create((x,y)=> (int)(y - x)));

        foreach(long num in nums)
            pq.Enqueue(num,num);

        while(k>0 && pq.Count >0)
        {
            k-=1;
            long number = pq.Dequeue();
            maxResult+=number;
            long newNum = (long)Math.Ceiling((decimal)number/3);
            pq.Enqueue(newNum, newNum);
        }
        return maxResult;
    }
}