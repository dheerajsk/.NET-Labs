using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Queue
    {
        private int[] elements;
        private int front;
        private int rear;
        private int max;

        public Queue(int size)
        {
            elements = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public static void Do()
        {
            Queue q = new Queue(10);
            q.insert(10);
            q.insert(20);
            q.insert(30);
            q.insert(40);
            q.insert(50);
            q.insert(60);
            q.insert(70);
            q.insert(80);
            q.insert(90);
            q.insert(100);
            Console.WriteLine(q.printQueue());
            q.delete();
            q.delete();
            Console.WriteLine(q.printQueue());
        }

        public void insert(int item)
        {
            if (rear == max - 1)
            {
                return;
            }
            else
            {
                //Console.WriteLine(elements[++rear]);
                elements[++rear] = item;
            }
        }

        public int delete()
        {
            if (front == rear + 1)
            {
                return -1;
            }
            else
            {
                //Console.WriteLine(elements[front++]);
                return elements[front++];
            }
        }

        public string printQueue()
        {
            string result = "";
            if (front == rear + 1)
            {
                return result;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    result += elements[i] + " ";
                }
            }

            return result;
        }
    }
}
