using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;

namespace LeetCode.Learn.LinkedList.Problems
{
    class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode listOne, ListNode listTwo)
        {
            if (listOne is null)
                return listTwo;

            if (listTwo is null)
                return listOne;

            ListNode newNodeHead = null;
            ListNode currentNode = null;
            ListNode previosNode = null;

            while (listOne != null && listTwo != null)
            {
                if (listOne.val < listTwo.val)
                {
                    currentNode = listOne;
                    listOne = listOne.next;
                }
                else
                {
                    currentNode = listTwo;
                    listTwo = listTwo.next;
                }

                if (newNodeHead is null)
                {
                    newNodeHead = currentNode;
                    previosNode = currentNode;
                }
                else
                {
                    previosNode.next = currentNode;
                    previosNode = currentNode;
                }
            }

            if (listOne != null)
            {
                previosNode.next = listOne;
                previosNode = listOne;
                listOne = listOne.next;
            }

            if (listTwo != null)
            {
                previosNode.next = listTwo;
                previosNode = listTwo;
                listTwo = listTwo.next;
            }

            return newNodeHead;
        }
    }
}
