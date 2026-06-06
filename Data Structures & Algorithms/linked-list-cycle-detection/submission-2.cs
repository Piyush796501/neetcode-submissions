/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode first=head;
        ListNode second=head;
        if(head==null)
         return false;
        
        while(second!=null && second.next!=null)
        {
          first=first.next;
          second=second.next.next;
          if(first==second)
            return true;
        }
        return false;
    }
}
