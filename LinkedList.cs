using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkList
    {
        public Node? First { get; set; }

        public void InsertFirst(int data)
        {
            //Create the node
            Node newNode = new Node();
            //Put the data in the Node
            newNode.Data = data;
            //Put the old node to next
            newNode.Next = First;
            //Make the first the new node
            First = newNode;
        }

        public Node DeleteFirst()
        {
            //Assign the temporary variable
            Node temp = First;
            //Assign the new head
            First = First.Next;
            return temp;
        }

        public Node DeleteLast()
        {
            if(First == null)
            {
                return null;
            }
            else
            {
                Node current = First;
                while(current.Next.Next != null)
                {
                    current = current.Next;
                }
                Node temp = current.Next;
                current.Next = null;
                return temp;
            }
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating thru list...");
            Node current = First;
            while(current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if (First != null)
            {
                Node current = First;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            else
            {
                First = newNode;
            }
        }

        public void InsertAfter(int val, int data)
        {
            Node current = First;
            while(current != null)
            {
                if(current.Data == val)
                {
                    Node newNode = new Node();
                    newNode.Data = data;
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                }
                current = current.Next;
            }
        }

        public void InsertBefore(int val, int data)
        {
            Node current = First;
            while(current != null)
            {
                if(current.Next.Data == val)
                {
                    Node newNode = new Node();
                    newNode.Data = data;
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                }
                current = current.Next;
            }
        }
    }
}
