using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;

namespace LeetCode.Learn.LinkedList.Problems.Extra
{
    public class Node
    {
        public int val;
        public Node prev;
        public Node next;
        public Node child;
    }

    class FlattenMultilevelDoublyLinkedList
    {
        public Node Flatten(Node head)
        {
            if (head == null)
            {
                return null;
            }
            var node = head;
            while (node != null)
            {
                if (node.child != null)
                {
                    var child = node.child;
                    var nextNode = node.next;
                    var childEnd = child;

                    while (childEnd.next != null)
                    {
                        childEnd = childEnd.next;
                    }

                    node.next = child;
                    child.prev = node;

                    if (nextNode != null)
                    {
                        nextNode.prev = childEnd;
                        childEnd.next = nextNode;
                    }

                    node.child = null;
                    continue;

                }

                node = node.next;
            }
            return head;
        }
    }
}
