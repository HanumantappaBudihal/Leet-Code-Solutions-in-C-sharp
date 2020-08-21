using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.LinkedList.Problems
{
    class IntersectionOfTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA is null || headB is null)
                return null;

            int chainAcount = 0;
            int chainBCount = 0;
            var chainNodeA = headA;
            var chainNodeB = headB;

            //Find out the A and B chain length
            while (chainNodeA.next != null)
            {
                chainAcount++;
                chainNodeA = chainNodeA.next;
            }

            while (chainNodeB.next != null)
            {
                chainBCount++;
                chainNodeB = chainNodeB.next;
            }

            if (chainAcount > chainBCount)
            {
                int temp = chainAcount - chainBCount;
                chainNodeA = headA;

                while (temp > 0)
                {
                    chainNodeA = chainNodeA.next;
                    temp--;
                }

                chainNodeB = headB;
            }
            else if (chainAcount < chainBCount)
            {
                int temp = chainBCount - chainAcount;
                chainNodeB = headB;

                while (temp > 0)
                {
                    chainNodeB = chainNodeB.next;
                    temp--;
                }

                chainNodeA = headA;
            }
            else
            {
                chainNodeA = headA;
                chainNodeB = headB;
            }

            while (chainNodeA != chainNodeB)
            {
                chainNodeA = chainNodeA.next;
                chainNodeB = chainNodeB.next;
            }

            return chainNodeA;
        }
    }
}

