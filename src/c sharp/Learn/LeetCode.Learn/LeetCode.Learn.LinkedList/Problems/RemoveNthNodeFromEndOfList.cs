using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.LinkedList.Problems
{
    class RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode deletePointer = head;
            ListNode iteratorPointer = head;

            while (iteratorPointer.next != null)
            {
                if (n != 0)
                    n--;
                else deletePointer = deletePointer.next;

                iteratorPointer = iteratorPointer.next;
            }

            //if n is left with n==1, it means header node has remove

            if (n != 1 && deletePointer.next != null)
                deletePointer.next = deletePointer.next.next;
            else if (n == 1)
                head = head.next;

            return head;
        }
    }
}
