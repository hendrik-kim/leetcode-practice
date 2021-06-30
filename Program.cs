using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(0, null);
            ListNode node1 = new ListNode(1, null);
            ListNode node2 = new ListNode(2, null);
            ListNode node3 = new ListNode(3, null);

            head.next = node1;
            node1.next = node2;
            node3.next = node3;

            ReverseLinkedList reverse = new ReverseLinkedList();

            reverse.ReverseList(head);

        }
    }
}
