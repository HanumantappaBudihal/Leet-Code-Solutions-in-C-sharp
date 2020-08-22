using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace LeetCode.Learn.LinkedList.Problems
{
    class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            // find middle of the given linked list && p1 will point to middle node
            ListNode pointer1 = head;
            ListNode pointer2 = head;
            while (pointer2 != null && pointer2.next != null)
            {
                pointer1 = pointer1.next;
                pointer2 = pointer2.next.next;
            }

            // reversing first half
            ListNode tempPoninter = null;
            ListNode previousPointer = null;
            ListNode currentPointer = head;

            while (currentPointer != pointer1)
            {
                tempPoninter = currentPointer.next;
                currentPointer.next = previousPointer;
                previousPointer = currentPointer;
                currentPointer = tempPoninter;
            }

            // odd number of elements, need left move p1 one step
            if (pointer2 != null && pointer2.next == null) pointer1 = pointer1.next;

            while (pointer1 != null)
            {
                if (pointer1.val != previousPointer.val) return false;
                pointer1 = pointer1.next;
                previousPointer = previousPointer.next;
            }

            return true;
        }

      

        //Method 2 : Not completed solution
        public bool IsPalindrome_Method(ListNode head)
        {
            if (head is null)
                return true;

            StringBuilder stringBuilder = new StringBuilder();
            ListNode listNode = head;

            while (listNode != null)
            {
                stringBuilder.Append(listNode.val);
                listNode = listNode.next;
            }

            var stringValue = stringBuilder.ToString();
            var reverseString = GetReverseString(stringValue);
            return stringValue.Equals(reverseString);
        }

        public string GetReverseString(string name)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                builder.Append(name[i]);
            }

            return builder.ToString();
        }
    }
}
