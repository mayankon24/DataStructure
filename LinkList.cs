using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace dataStructure
{
    class LinkList
    {
        public class Node
        {
            public object nodeContant;
            public Node Next;
        }

        Node head;
        int count;

        public void AddNode(object NodeContant)
        {
            count++;

            Node newNode = new Node();
            newNode.nodeContant = NodeContant;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node tempNode = head;
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = newNode;
            }
        }

        public void AddNode(object NodeContant, int position)
        {
            count++;

            Node newNode = new Node();
            newNode.nodeContant = NodeContant;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node tempNode = head;
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = newNode;
            }

        }
    }
}
