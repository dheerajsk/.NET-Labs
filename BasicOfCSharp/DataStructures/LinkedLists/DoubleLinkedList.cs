using System;

namespace DataStructures.LinkedLists
{
    class DoubleLinkedList
    {

        private DLNode root = null;

        public DLNode Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length { get; set; }

        public DLNode Current { get; set; }


        public static void Do()
        {
            DoubleLinkedList list = new DoubleLinkedList();
            DLNode node = new DLNode();
            node.Data = "root";
            list.Add(node);
            for (int i = 0; i < 10; i++)
            {
                DLNode nodeInLoop = new DLNode();
                nodeInLoop.Data = i.ToString();
                list.Add(nodeInLoop);
            }

            Console.WriteLine("Length of double linked list is - {0}", list.GetLength());

            Console.WriteLine("Traversing forward...\n");
            DLNode nodeToRead = list.GetRoot();
            while (nodeToRead != null)
            {
                Console.WriteLine(nodeToRead.Data);
                nodeToRead = list.GetNext();
            }

            Console.WriteLine("Traversing backwards...");
            nodeToRead = list.GetPrev();
            while (nodeToRead != null)
            {
                Console.WriteLine(nodeToRead.Data);
                nodeToRead = list.GetPrev();
            }
        }

        public void Add(DLNode node)
        {
            node.Next = null;
            if (root == null)
            {
                root = node;
                Length = 1;
                Current = root;
                root.Prev = null;
            }
            else
            {
                Current.Next = node;
                node.Prev = Current;
                Current = node;
                Length++;
            }
        }

        public DLNode GetCurrent()
        {
            return this.Current;
        }

        public DLNode GetRoot()
        {
            Current = root;
            return this.root;
        }

        public DLNode GetNext()
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

        public DLNode GetPrev()
        {
            if (Current.Prev is null)
            {
                return null;
            }
            else
            {
                Current = Current.Prev;
                return Current;
            }
        }

        public int GetLength()
        {
            return this.Length;
        }

    }
}
