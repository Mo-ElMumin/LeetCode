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
    public ListNode ReverseList(ListNode head) 
    {
        ListNode temp2; 
        ListNode temp1 = null;
        
        while (head != null)
        {
            temp2 = head.next;
            head.next = temp1;
            temp1 = head;
            head = temp2;
        }
        
        return temp1;
    }
}
