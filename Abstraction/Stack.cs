using System;

class Stack<T>
{
    private T[] stack;
    private int max;
    private int pointer = -1;

    public Stack(int max)
    {
        this.max = max;
        this.stack = new T[max];
    }

    public void Push(T item)
    {
        if (pointer == max - 1)
        {
            throw new System.ArgumentException("Stack full");
        }
        pointer++;
        stack[pointer] = item;
    }


    public void Pop()
    {
        if (pointer < 0)
        {
            throw new System.ArgumentException("Stack empty");
        }
        pointer--;
    }

    public void Log()
    {
        for (int i = 0; i <= pointer; i++)
        {
            Console.WriteLine(stack[i]);
        }
    }
}