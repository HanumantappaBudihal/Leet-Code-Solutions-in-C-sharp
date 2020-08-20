using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.LinkedList.Problems
{
    //Nodes in linkde list
    class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }

    class MyLinkedList
    {
        private Node _headNode;
        /** Initialize your data structure here. */
        public MyLinkedList()
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (_headNode != null)
            {
                var nextNode = _headNode;
                while (index-- > 0 && !(nextNode.NextNode is null))
                {
                    nextNode = nextNode.NextNode;
                }

                if (index == (-1))
                    return nextNode.Value;
            }

            return -1;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int value)
        {
            if (_headNode is null)
            {
                _headNode = new Node(value);
            }
            else
            {
                Node node = new Node(value);
                //TODO : Need to verify the logic
                node.NextNode = _headNode;
                _headNode = node;
            }
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int value)
        {
            if (_headNode is null)
            {
                _headNode = new Node(value);
            }
            else
            {
                var nextNode = _headNode;

                //Traverse till end of the linked list
                while (!(nextNode.NextNode == null))
                {
                    nextNode = nextNode.NextNode;
                }

                nextNode.NextNode = new Node(value);
            }
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int value)
        {
            if (_headNode != null)
            {
                if (index == 0)
                {
                    AddAtHead(value);
                    return;
                }

                Node nextNode = _headNode;
                while (--index > 0 && !(nextNode.NextNode is null))
                {
                    nextNode = nextNode.NextNode;
                }

                if (index == 0)
                {
                    if (nextNode.NextNode is null)
                        nextNode.NextNode = new Node(value);
                    else
                    {
                        var newNode = new Node(value);
                        newNode.NextNode = nextNode.NextNode;
                        nextNode.NextNode = newNode;
                    }
                }
            }
            else if (index == 0)
            {
                AddAtHead(value);
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (_headNode != null)
            {
                if (index == 0)
                {
                    _headNode = _headNode.NextNode;
                    return;
                }

                Node nextNode = _headNode;
                while (--index > 0 && !(nextNode.NextNode is null))
                {
                    nextNode = nextNode.NextNode;
                }

                if (index == 0)
                {
                    if (nextNode.NextNode != null)
                    {
                        nextNode.NextNode = nextNode.NextNode.NextNode;
                    }
                }
            }
        }
    }
}
