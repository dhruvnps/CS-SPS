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

        if (last != null)
        {
            last.next = node;
        }
        else
        {
            first = node;
        }
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
}