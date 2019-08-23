using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList
    {
        public static void Main()
        {
            MyLinkedList mll = new MyLinkedList(10);
            mll.AddFirst(11);
            mll.AddFirst(12);
            mll.AddFirst(13);

            mll.Add(4, 8);
            mll.Add(4, 9);
            mll.PrintList();
        }
    }

    public class MyLinkedList
    {
        private Node head;
        private int numNodes = 0;

        public MyLinkedList(object data)
        {
            head = new Node(data);
        }

        public class Node
        {
            private Node next;
            private object data;

            public object Data { get => data; set => data = value; }
            public Node Next { get => next; set => next = value; }

            public Node(object data)
            {
                Data = data;
            }
        }

        public void Add(int index, object data)
        {
            Node temp = head;
            Node holder;

            for (int i = 0; i < index - 1 && temp.Next != null; i++)
            {
                temp = temp.Next;
            }

            holder = temp.Next;
            temp.Next = new Node(data);
            temp.Next.Next = holder;
            numNodes++;
        }

        public void AddFirst(object data)
        {
            Node temp = head;
            head = new Node(data);
            head.Next = temp;
            numNodes++;
        }

        public Node Get(int index)
        {
            Node temp = head;
            for (int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp;
        }

        public void PrintList()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
