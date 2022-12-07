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
    public ListNode DeleteDuplicates(ListNode head) 
    {
        ListNode holder = new ListNode();
        ListNode mover = new ListNode();

        if (head == null || head.next == null)
        {
            return head;
        }

        holder = head;
        mover = head.next;
        while (mover != null)
        {
            if (holder.val == mover.val)
            {
                holder.next = null;
                mover = mover.next;

            }
            else 
            {
                holder.next = mover;
                holder = holder.next;
                mover = mover.next;
            }
        } // end while 

        return head; 
    }
}
