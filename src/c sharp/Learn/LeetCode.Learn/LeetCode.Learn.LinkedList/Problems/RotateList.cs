using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.LinkedList.Problems
{
    class RotateListProblem
    {
        public ListNode RotateRight(ListNode head, int numberOfRotation)
        {
            if (head is null || numberOfRotation < 1)
                return head;

            ListNode slowPointer = head;
            ListNode fastPointer = head;

            if (head == null)
            {
                return null;
            }

            ListNode node = head;
            int count = 0;
            while (node != null)
            {
                node = node.next;
                count++;
            }

            numberOfRotation = numberOfRotation % count;
            for (int i = 0; i < numberOfRotation; i++)
            {
                fastPointer = fastPointer.next;
            }

            while (fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next;
            }

            fastPointer.next = head;
            ListNode result = slowPointer.next;
            slowPointer.next = null;

            return result;
        }
    }
}
