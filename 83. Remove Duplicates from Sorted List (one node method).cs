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
        ListNode linker = new ListNode();

        if (head == null || head.next == null)
        {
            return head;
        }

        linker = head;
        while (linker != null && linker.next != null)
        {
            if (linker.val == linker.next.val)
            {
                linker.next = linker.next.next;
            }
            else 
            {
                linker = linker.next;
            }
        } // end while

        return head; 
    }
}
