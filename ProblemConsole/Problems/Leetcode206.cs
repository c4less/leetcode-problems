

public class Leetcode206 {
    public ListNode ReverseList(ListNode head) {
        var current = head;
        ListNode prev = null;

        while(current is not null)
        {
          var next = current.next;
            current.next = prev;
            (prev,current) = (current,next); 
        }
        return prev;
    }
}



  public class ListNode {
     public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }