using System.Threading.Tasks.Dataflow;

namespace LeetCode.Learn.LinkedList.Problems
{
    //Floyd's algorithms : O(n) -> Time complexity , O(1) : Space complexity
    class LinkedListCycle2
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return null;

            ListNode slowNode = head;
            ListNode fastNode = head;
            ListNode pointNode = null;

            //Check here , does linked list has the cycle
            while (fastNode != null && fastNode.next != null)
            {
                slowNode = slowNode.next;
                fastNode = fastNode.next.next;

                if (slowNode == fastNode)
                {
                    pointNode = head;
                    while (pointNode != slowNode)
                    {
                        pointNode = pointNode.next;
                        slowNode = slowNode.next;
                    }

                    break;
                }                
            }

            return pointNode;
        }
    }
}
