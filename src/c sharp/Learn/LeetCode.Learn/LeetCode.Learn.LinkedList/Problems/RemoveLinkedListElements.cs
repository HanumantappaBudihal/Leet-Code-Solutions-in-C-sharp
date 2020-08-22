using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.LinkedList.Problems
{
    class RemoveLinkedListElements
    {
        //Better solution
        public ListNode RemoveElements(ListNode headNode, int value)
        {
            if (headNode == null)
                return null;

            var currentNode = headNode;
            while (currentNode.next != null)
            {
                if (currentNode.next.val == value)
                    currentNode.next = currentNode.next.next;
                else
                    currentNode = currentNode.next;
            }

            return headNode.val != value ? headNode : headNode.next;
        }


        //public ListNode RemoveElements(ListNode head, int value)
        //{
        //    if (head is null)
        //        return head;

        //    ListNode node = head;
        //    ListNode previousNode = null;          

        //    while (node != null)
        //    {
        //        if (node.value == value)
        //        {
        //            if (previousNode is null)
        //            {
        //                head = head.next;
        //                node = head;

        //                continue;
        //            }

        //            previousNode.next = node.next;
        //            node = node.next;
        //            continue;
        //        }

        //        previousNode = node;
        //        node = node.next;               
        //    }

        //    return head;
        //}
    }
}
