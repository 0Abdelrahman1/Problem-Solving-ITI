
/* Definition for singly-linked list. */
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class removenthnodefromendoflist
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int len = 0;
        ListNode cur = head;

        while (cur != null)
        {
            len++;
            cur = cur.next;
        }
        if (len == n) return head.next;

        cur = head;
        for (int i = 0; i < len - n - 1; i++)
            cur = cur.next;

        cur.next = cur.next.next;
        return head;
    }
}