using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{
    class SingleLinkedList
    {
        private Node root = null;

        public Node Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length { get; set; }

        public Node Current { get; set; }


        public static void Do()
        {
            SingleLinkedList list = new SingleLinkedList();
            Node node = new Node();
            node.Data = "root";
            list.Add(node);
            for (int i = 0; i < 10; i++)
            {
                Node nodeInLoop = new Node();
                nodeInLoop.Data = i.ToString();
                list.Add(nodeInLoop);
            }

            Console.WriteLine("Length of linked list is - {0}", list.GetLength());

            Node nodeToRead = list.GetRoot();
            while (nodeToRead != null)
            {
                Console.WriteLine(nodeToRead.Data);
                nodeToRead = list.GetNext();
            }

        }

        public void Add(Node node)
        {
            node.Next = null;
            if (root is null)
            {
                root = node;
                Length = 1;
                Current = root;
            }
            else
            {
                Current.Next = node;
                Current = node;
                Length++;
            }
        }

        public Node GetCurrent()
        {
            return this.Current;
        }

        public Node GetRoot()
        {
            Current = root;
            return this.root;
        }

        public Node GetNext()
        {
            if (Current.Next is null)
            {
                return null;
            }
            else
            {
                Current = Current.Next;
                return Current;
            }
        }

        public int GetLength()
        {
            return this.Length;
        }

    }
}
