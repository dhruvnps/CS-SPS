using System;
using System.Collections.Generic;

class LinkedList<T>
{
    private Node head;
    private Node tail;
    public int Count = 0;

    private class Node
    {
        public T item;
        public Node next;
        public Node(T item, Node next)
        {
            this.item = item;
            this.next = next;
        }
    }

    public void Add(T item)
    {
        Node node = new Node(item, next: null);
        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        Count++;
    }

    public void RemoveAt(int index)
    {
        if (index == 0)
        {
            this.head = this.head.next;
        }
        else
        {
            Node node = this.head;
            for (int i = 0; i < index - 1; i++)
            {
                node = node.next;
                if (node == null)
                {
                    throw new ArgumentNullException("Index out of range");
                }
            }
            node.next = node.next.next;
            if (node == null)
            {
                tail = null;
            }
        }
        Count--;
    }

    public T this[int index]
    {
        get
        {
            Node node = this.head;
            for (int i = 0; i < index; i++)
            {
                node = node.next;
                if (node == null)
                {
                    throw new ArgumentNullException("Index out of range");
                }
            }
            return node.item;
        }
    }
}