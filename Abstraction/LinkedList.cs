using System;
using System.Collections;
using System.Collections.Generic;

class LinkedList<T> : IList<T>
{
    private Node head;
    private Node tail;
    public int Count { get; private set; }

    // not implemented yet
    public bool IsReadOnly { get; }

    public LinkedList()
    {
        Count = 0;
        head = null;
        tail = null;
    }

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

    public IEnumerator<T> GetEnumerator()
    {
        Node node = head;
        for (int i = 0; i < Count; i++)
        {
            yield return node.item;
            node = node.next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
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

    public bool Remove(T item)
    {
        Node node = head;
        if (EqualityComparer<T>.Default.Equals(item, head.item))
        {
            head = head.next;
        }
        for (int i = 0; i < Count - 1; i++)
        {
            if (EqualityComparer<T>.Default.Equals(item, node.next.item))
            {
                node.next = node.next.next;
                Count--;
                return true;
            }
            node = node.next;
        }
        return false;
    }

    public void RemoveAt(int idx)
    {
        if (idx >= Count)
        {
            throw new IndexOutOfRangeException();
        }
        if (idx == 0)
        {
            head = head.next;
        }
        else
        {
            Node node = head;
            for (int i = 0; i < idx - 1; i++)
            {
                node = node.next;
            }
            node.next = node.next.next;
        }
        Count--;
    }

    public void Insert(int idx, T item)
    {
        if (idx >= Count)
        {
            throw new IndexOutOfRangeException();
        }
        if (idx == 0)
        {
            Node node = new Node(item, next: head);
            head = node;
        }
        else
        {
            Node node = head;
            for (int i = 0; i < idx - 1; i++)
            {
                node = node.next;
            }
            node.next = new Node(item, next: node.next);
        }
        Count++;
    }

    public void Clear()
    {
        head = null;
        tail = null;
        Count = 0;
    }

    public void CopyTo(T[] arr, int idx)
    {
        Node node = head;
        for (int i = idx; i < Count; i++)
        {
            arr[i] = node.item;
            node = node.next;
        }
    }

    public bool Contains(T item)
    {
        Node node = head;
        for (int i = 0; i < Count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(item, node.item))
            {
                return true;
            }
            node = node.next;
        }
        return false;
    }

    public int IndexOf(T item)
    {
        Node node = head;
        for (int i = 0; i < Count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(item, node.item))
            {
                return i;
            }
            node = node.next;
        }
        return -1;
    }

    public T this[int idx]
    {
        get
        {
            if (idx >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            Node node = this.head;
            for (int i = 0; i < idx; i++)
            {
                node = node.next;
            }
            return node.item;
        }
        set
        {
            if (idx >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            Node node = this.head;
            for (int i = 0; i < idx; i++)
            {
                node = node.next;
            }
            node.item = value;
        }
    }
}