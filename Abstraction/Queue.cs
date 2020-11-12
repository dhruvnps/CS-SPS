using System;

class Queue<T>
{
    private Node first;
    private Node last;

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

    public void Append(T item)
    {
        Node node = new Node(item, next: null);
        if (first == null)
        {
            first = node;
            last = node;
            return;
        }
        last.next = node;
        last = node;
    }

    public T Remove()
    {
        if (first == null)
        {
            throw new ArgumentNullException("Queue is empty");
        }
        T item = first.item;
        first = first.next;
        if (first == null)
        {
            last = null;
        }
        return item;
    }

    public T Peek()
    {
        return first.item;
    }
}

class CircularQueue<T>
{
    private T[] array;
    private int first = 0;
    private int last = 0;
    private int max;

    public CircularQueue(int max = 10)
    {
        array = new T[max];
        this.max = max;
    }

    public void Append(T item)
    {
        array[last % max] = item;
        last++;
    }

    public T Remove()
    {
        first++;
        return array[(first - 1) % max];
    }

    public T Peek()
    {
        return array[first % 4];
    }
}