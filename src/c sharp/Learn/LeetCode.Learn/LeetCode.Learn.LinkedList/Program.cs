using System;
using LeetCode.Learn.LinkedList.Problems;

namespace LeetCode.Learn.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //1.DesingLinkedList_Main
            //DesingLinkedList_Main();

            //2.Linked List Cycle
            //LinkedListCycle_Main();

            //3.Linked list cycle 2
            //LinkedListCycle2_Main();

            //4.IntersectionOfTwoLinkedLists
            //IntersectionOfTwoLinkedLists_Main();

            //5. RemoveNthNodeFromEndOfList
            //RemoveNthNodeFromEndOfList_Main();

            //6. ReverseLinkedList
            //ReverseLinkedList_Main();

            //7. RemoveLinkedListElements
            //RemoveLinkedListElements_Main();

            //8. OddEvenLinkedList
            //OddEvenLinkedList_Main();

            //9.PalindromeLinkedList
            //PalindromeLinkedList_Main();

            //10.MergeTwoSortedLists
            //MergeTwoSortedLists_Main();

            //11  Add two numbers
            AddTwoNumbersProblem_Main();
        }

        private static void AddTwoNumbersProblem_Main()
        {
            AddTwoNumbersProblem addTwoNumbersProblem = new AddTwoNumbersProblem();
            //Chain A build
            ListNode NodeAHead = new ListNode(1);
            ListNode NodeA1 = new ListNode(3);
            NodeAHead.next = NodeA1;
            ListNode NodeA8 = new ListNode(5);
            NodeA1.next = NodeA8;
            //ListNode NodeA4 = new ListNode(7);
            //NodeA8.next = NodeA4;

            //ListNode NodeA5 = new ListNode(9);
            //NodeA4.next = NodeA5;


            ListNode NodeBHead = new ListNode(2);

            ListNode NodeB6 = new ListNode(6);
            NodeBHead.next = NodeB6;

            ListNode NodeB1 = new ListNode(1);
            NodeB6.next = NodeB1;

            //Interction

            var result = addTwoNumbersProblem.AddTwoNumbers(NodeAHead, NodeBHead);

            //Test 2
            /*
             * Input:
                [5]
                [5]
              
                Expected:
                [0,1]*/
            NodeAHead = new ListNode(5);
            //NodeA1 = new ListNode(3);
            //NodeAHead.next = NodeA1;
            //NodeA8 = new ListNode(5);
            //NodeA1.next = NodeA8;
            //ListNode NodeA4 = new ListNode(7);
            //NodeA8.next = NodeA4;

            //ListNode NodeA5 = new ListNode(9);
            //NodeA4.next = NodeA5;


            NodeBHead = new ListNode(5);

            //NodeB6 = new ListNode(6);
            //NodeBHead.next = NodeB6;

            //NodeB1 = new ListNode(1);
            //NodeB6.next = NodeB1;

            //Interction

            result = addTwoNumbersProblem.AddTwoNumbers(NodeAHead, NodeBHead);

            //Test case 3
            /*Input:
            [1,8]
            [0]
            Output:
                    [8,1]
            Expected:
                     [1,8] */

            NodeAHead = new ListNode(1);
            NodeA1 = new ListNode(8);
            NodeAHead.next = NodeA1;

            NodeBHead = new ListNode(0);

            result = addTwoNumbersProblem.AddTwoNumbers(NodeAHead, NodeBHead);
        }

        private static void MergeTwoSortedLists_Main()
        {
            MergeTwoSortedLists mergeTwoSortedLists = new MergeTwoSortedLists();
            //Chain A build
            ListNode NodeAHead = new ListNode(1);
            ListNode NodeA1 = new ListNode(3);
            NodeAHead.next = NodeA1;
            ListNode NodeA8 = new ListNode(5);
            NodeA1.next = NodeA8;
            ListNode NodeA4 = new ListNode(7);
            NodeA8.next = NodeA4;

            ListNode NodeA5 = new ListNode(9);
            NodeA4.next = NodeA5;


            ListNode NodeBHead = new ListNode(2);

            ListNode NodeB6 = new ListNode(6);
            NodeBHead.next = NodeB6;

            ListNode NodeB1 = new ListNode(10);
            NodeB6.next = NodeB1;

            //Interction
            NodeB1.next = NodeA8;
            var result = mergeTwoSortedLists.MergeTwoLists(NodeAHead, NodeBHead);

        }

        private static void PalindromeLinkedList_Main()
        {
            PalindromeLinkedList palindromeLinkedList = new PalindromeLinkedList();
            //Chain A build
            ListNode NodeAHead = new ListNode(1);

            ListNode NodeA1 = new ListNode(2);
            NodeAHead.next = NodeA1;


            ListNode NodeA8 = new ListNode(2);
            NodeA1.next = NodeA8;

            //ListNode NodeA4 = new ListNode(1);
            //NodeA8.next = NodeA4;

            //ListNode NodeA5 = new ListNode(5);
            //NodeA4.next = NodeA5;

            var result = palindromeLinkedList.IsPalindrome(NodeAHead);

            //Test case 2
            ListNode NodeBHead = new ListNode(-123);

            ListNode NodeB1 = new ListNode(-123);
            NodeBHead.next = NodeB1;

            //ListNode NodeB8 = new ListNode(1);
            //NodeB1.next = NodeB8;

            result = palindromeLinkedList.IsPalindrome(NodeBHead);
        }

        private static void OddEvenLinkedList_Main()
        {
            OddEvenLinkedList oddEvenLinkedList = new OddEvenLinkedList();
            //Chain A build
            ListNode NodeAHead = new ListNode(1);

            ListNode NodeA1 = new ListNode(2);
            NodeAHead.next = NodeA1;

            ListNode NodeA8 = new ListNode(3);
            NodeA1.next = NodeA8;

            ListNode NodeA4 = new ListNode(4);
            NodeA8.next = NodeA4;

            ListNode NodeA5 = new ListNode(5);
            NodeA4.next = NodeA5;

            var result = oddEvenLinkedList.OddEvenList(NodeAHead);
        }

        private static void RemoveLinkedListElements_Main()
        {
            RemoveLinkedListElements removeLinkedListElements = new RemoveLinkedListElements();
            //Chain A build
            ListNode NodeAHead = new ListNode(4);

            ListNode NodeA1 = new ListNode(1);
            NodeAHead.next = NodeA1;

            ListNode NodeA8 = new ListNode(1);
            NodeA1.next = NodeA8;

            ListNode NodeA4 = new ListNode(4);
            NodeA8.next = NodeA4;

            //ListNode NodeA5 = new ListNode(5);
            //NodeA4.next = NodeA5;


            var result = removeLinkedListElements.RemoveElements(NodeAHead, 4);

            //Think about the different test cases
            //Edage  cases
            //Input:  [1,2,2,1] , 2            
            //Expected: [1,1]

        }

        private static void ReverseLinkedList_Main()
        {
            ReverseLinkedList reverseLinkedList = new ReverseLinkedList();
            //Chain A build
            ListNode NodeAHead = new ListNode(4);

            ListNode NodeA1 = new ListNode(1);
            NodeAHead.next = NodeA1;

            ListNode NodeA8 = new ListNode(8);
            NodeA1.next = NodeA8;

            ListNode NodeA4 = new ListNode(4);
            NodeA8.next = NodeA4;

            ListNode NodeA5 = new ListNode(5);
            NodeA4.next = NodeA5;

            //Test case 1 : Positive case -> Delete 2nd last
            var result = reverseLinkedList.ReverseList(NodeAHead);
        }

        private static void RemoveNthNodeFromEndOfList_Main()
        {
            RemoveNthNodeFromEndOfList removeNthNodeFromEndOfList = new RemoveNthNodeFromEndOfList();
            //Chain A build
            ListNode NodeAHead = new ListNode(4);

            ListNode NodeA1 = new ListNode(1);
            NodeAHead.next = NodeA1;

            ListNode NodeA8 = new ListNode(8);
            NodeA1.next = NodeA8;

            ListNode NodeA4 = new ListNode(4);
            NodeA8.next = NodeA4;

            ListNode NodeA5 = new ListNode(5);
            NodeA4.next = NodeA5;

            //Test case 1 : Positive case -> Delete 2nd last
            removeNthNodeFromEndOfList.RemoveNthFromEnd(NodeAHead, 2);

            //Test case 2 : Delete the last element
            removeNthNodeFromEndOfList.RemoveNthFromEnd(NodeAHead, 1);

            //Test case 3 : when n=0; Don't delete any items
            removeNthNodeFromEndOfList.RemoveNthFromEnd(NodeAHead, 0);

            //Test case : delete the Head > only 3  nodes left in list
            var result = removeNthNodeFromEndOfList.RemoveNthFromEnd(NodeAHead, 3);
        }

        private static void IntersectionOfTwoLinkedLists_Main()
        {
            IntersectionOfTwoLinkedLists intersectionOfTwoLinkedLists = new IntersectionOfTwoLinkedLists();
            //Chain A build
            ListNode NodeAHead = new ListNode(4);
            ListNode NodeA1 = new ListNode(1);
            NodeAHead.next = NodeA1;
            ListNode NodeA8 = new ListNode(8);
            NodeA1.next = NodeA8;
            ListNode NodeA4 = new ListNode(4);
            NodeA8.next = NodeA4;

            ListNode NodeA5 = new ListNode(5);
            NodeA4.next = NodeA5;


            ListNode NodeBHead = new ListNode(5);

            ListNode NodeB6 = new ListNode(6);
            NodeBHead.next = NodeB6;

            ListNode NodeB1 = new ListNode(1);
            NodeB6.next = NodeB1;

            //Interction
            NodeB1.next = NodeA8;
            var result = intersectionOfTwoLinkedLists.GetIntersectionNode(NodeAHead, NodeBHead);


            //Disconnecting lists from interction
            NodeA1.next = null;
            NodeB1.next = null;
            result = intersectionOfTwoLinkedLists.GetIntersectionNode(NodeAHead, NodeBHead);

            //case 3
            NodeAHead.next = null;
            NodeB6.next = NodeAHead;
            result = intersectionOfTwoLinkedLists.GetIntersectionNode(NodeAHead, NodeAHead);
        }

        //3.Linked list cycle 3
        private static void LinkedListCycle2_Main()
        {
            //TODO : Need to apply the changes
            throw new NotImplementedException();
        }

        //1.Desing LinkedList
        static void DesingLinkedList_Main()
        {
            //Test 1
            MyLinkedList linkedList = new MyLinkedList(); // Initialize empty LinkedList
            linkedList.AddAtHead(1);
            linkedList.AddAtTail(3);
            linkedList.AddAtIndex(1, 2);  // linked list becomes 1->2->3
            var result = linkedList.Get(1);            // returns 2
            linkedList.DeleteAtIndex(1);  // now the linked list is 1->3
            result = linkedList.Get(1);            // returns 3

            //Test 2
            //["MyLinkedList","addAtHead","addAtHead","addAtHead","addAtIndex","deleteAtIndex","addAtHead","addAtTail","get","addAtHead","addAtIndex","addAtHead"]
            //[[],[7],[2],[1],[3,0],[2],[6],[4],[4],[4],[5,0],[6]]
            linkedList = new MyLinkedList();
            linkedList.AddAtHead(7);
            linkedList.AddAtHead(7);
            linkedList.AddAtHead(7);
            linkedList.AddAtIndex(3, 0);
            linkedList.DeleteAtIndex(2);
            linkedList.AddAtHead(6);
            linkedList.AddAtTail(4);
            result = linkedList.Get(4);
            linkedList.AddAtHead(4);
            linkedList.AddAtIndex(5, 0);
            linkedList.AddAtHead(6);

            //Test 3
            //Input:    ["MyLinkedList","addAtHead","addAtTail","addAtIndex","get","deleteAtIndex","get"]
            //[[],[1],[3],[1,2],[1],[0],[0]]
            //Expected:
            //[null,null,null,null,2,null,2]
            linkedList = new MyLinkedList();
            linkedList.AddAtHead(1);
            linkedList.AddAtTail(3);
            linkedList.AddAtIndex(1, 2);
            result = linkedList.Get(1);
            linkedList.DeleteAtIndex(0);
            result = linkedList.Get(0);

            /*Test 4
             * Input:
               ["MyLinkedList","addAtIndex","addAtIndex","addAtIndex","get"]
               [[],[0,10],[0,20],[1,30],[0]]
               Output:
               [null,null,null,null,-1]
               Expected:
               [null,null,null,null,20]
             */
            linkedList = new MyLinkedList();

            linkedList.AddAtIndex(0, 10);
            linkedList.AddAtIndex(0, 20);
            linkedList.AddAtIndex(1, 30);
            result = linkedList.Get(0);

            /*Test 5
             * ["MyLinkedList","addAtHead","get","addAtHead","addAtHead",
             *  "deleteAtIndex","addAtHead","get","get","get","addAtHead",
             *  "deleteAtIndex"]
               [[],[4],[1],[1],[5],[3],[7],[3],[3],[3],[1],[4]]
             */
            linkedList = new MyLinkedList();
            linkedList.AddAtHead(4);
            result = linkedList.Get(1);
            linkedList.AddAtHead(1);
            linkedList.AddAtHead(5);

            linkedList.DeleteAtIndex(5);
            linkedList.AddAtHead(3);

            result = linkedList.Get(7);
            result = linkedList.Get(3);
            result = linkedList.Get(3);
            linkedList.AddAtHead(4);
        }
    }
}
