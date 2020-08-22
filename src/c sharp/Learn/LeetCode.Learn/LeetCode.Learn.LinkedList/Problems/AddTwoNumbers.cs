using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.LinkedList.Problems
{
    class AddTwoNumbersProblem
    {
        public ListNode AddTwoNumbers(ListNode listOne, ListNode listTwo)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode tempListOne = listOne, tempListTwo = listTwo, currentNode = dummyHead;
            int carry = 0;

            while (tempListOne != null || tempListTwo != null)
            {
                int x = (tempListOne != null) ? tempListOne.val : 0;
                int y = (tempListTwo != null) ? tempListTwo.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                currentNode.next = new ListNode(sum % 10);
                currentNode = currentNode.next;
                if (tempListOne != null) tempListOne = tempListOne.next;
                if (tempListTwo != null) tempListTwo = tempListTwo.next;
            }
            if (carry > 0)
            {
                currentNode.next = new ListNode(carry);
            }

            return dummyHead.next;
        }
    }
}
