﻿using System;
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
            IntersectionOfTwoLinkedLists_Main();

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
