using System;

class Stack<T>
{
    private Node top;

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

    public void Push(T item)
    {
        top = new Node(item, next: top);
    }


    public T Pop()
    {
        if (top == null)
        {
            throw new ArgumentNullException("Stack is empty");
        }
        T item = top.item;
        top = top.next;
        return item;
    }

    public T Peek()
    {
        return top.item;
    }
}
