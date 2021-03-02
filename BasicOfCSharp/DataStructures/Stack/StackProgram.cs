using System;

namespace DataStructures.Stack
{
    class StackProgram
    {
        public Node Root { get; set; }

        public int Length { get; set; }

        public Node Current { get; set; }

        public static void Do()
        {
            StackProgram stack = new StackProgram();
            for (int i = 0; i < 10; i++)
            {
                Node node = new Node();
                node.Data = i.ToString();
                stack.Push(node);
            }
            Node poppedNode = stack.Pop();
            Console.WriteLine(poppedNode.Data);
            poppedNode = stack.Pop();
            Console.WriteLine(poppedNode.Data);
            Console.WriteLine(stack.Length);
            Console.WriteLine(stack.List());
        }

        public void Push(Node node)
        {
            node.Next = null;
            if (Root is null)
            {
                Root = node;
                Length = 1;
                Current = node;
                Root.Prev = null;
            }
            else
            {
                Current.Next = node;
                node.Prev = Current;
                Current = node;
                Length++;
            }
        }

        public Node Pop()
        {
            Node nodeToReturn = Current;
            if (Current is null)
            {
                return null;
            }
            else if (Current == Root)
            {
                Current = null;
                Root = null;
                Length = 0;
            }
            else
            {
                Current = Current.Prev;
                Current.Next = null;
                Length--;
            }
            return nodeToReturn;
        }

        public Node Peek()
        {
            if (Current is null || Current.Next is null)
            {
                return null;
            }
            else
            {
                return Current;
            }
        }

        public Node getRoot()
        {
            Current = Root;
            return this.Root;
        }

        public int GetLength()
        {
            return this.Length;
        }

        public string List()
        {
            string result = "";
            Current = Root;
            while (Current != null)
            {
                result += Current.Data + " ";
                Current = Current.Next;
            }
            Current = Root;
            return result;
        }

    }
}
