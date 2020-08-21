using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace LeetCode.Learn.LinkedList.Problems
{
    class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head is null)
                return null;

            ListNode currentNode = head;
            ListNode nextNode = null;
            ListNode previousNode = null;

            while (currentNode != null)
            {
                nextNode = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }

            head = previousNode;

            return head;
        }
    }
}
