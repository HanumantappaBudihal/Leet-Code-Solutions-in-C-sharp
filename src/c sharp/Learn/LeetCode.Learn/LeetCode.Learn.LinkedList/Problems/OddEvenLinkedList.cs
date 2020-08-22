using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeetCode.Learn.LinkedList.Problems
{
    class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head is null)
                return head;

            // Initialize first nodes of even and  
            // odd lists  
            ListNode even = head.next;
            ListNode odd = head;


            // Remember the first node of even list so  
            // that we can connect the even list at the  
            // end of odd list.  
            ListNode evenFirst = even;

            while (1 == 1)
            {
                // If there are no more nodes,  
                // then connect first node of even  
                // list to the last node of odd list  
                if (odd == null || even == null || (even.next) == null)
                {
                    odd.next = evenFirst;
                    break;
                }

                // Connecting odd nodes  
                odd.next = even.next;
                odd = even.next;

                // If there are NO more even nodes  
                // after current odd.  
                if (odd.next == null)
                {
                    even.next = null;
                    odd.next = evenFirst;
                    break;
                }

                // Connecting even nodes  
                even.next = odd.next;
                even = odd.next;
            }

            return head;
        }
    }
}
