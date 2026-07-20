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
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0) return null!;
        ListNode Merge2Lists(ListNode list1, ListNode list2)
        {
            ListNode list3 = new();
            var cur = list3;
            while (list1 != null && list2 != null)
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
            cur.next = list1 ?? list2!;
            return list3.next;
        }

        ListNode MergeLists(ListNode[] lists)
        {
            if (lists.Length == 1)
                return lists[0];
            int k = lists.Length / 2;
            return Merge2Lists(MergeLists(lists[..k]), MergeLists(lists[k..]));
        }

        return MergeLists(lists);
    }

    public ListNode MergeKLists1(ListNode[] lists)
    {
        PriorityQueue<ListNode, int> pq = new();

        foreach (ListNode list in lists)
        {
            var node = list;
            while (node != null)
            {
                pq.Enqueue(node, node.val);
                node = node.next;
            }
        }
        ListNode head = new();
        var cur = head;
        while (pq.Count > 0)
            cur = cur.next = new(pq.Dequeue().val);

        return head.next;
    }

}