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
public partial class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode list3 = new();
        var cur = list3;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                cur = cur.next = list1;
                list1 = list1.next;
            }
            else
            {
                cur = cur.next = list2;
                list2 = list2.next;
            }
        }
        cur.next = list1 ?? list2!;
        return list3.next;
    }
}