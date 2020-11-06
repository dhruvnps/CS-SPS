using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>(5);

            myStack.Push(10);
            myStack.Push(9090);
            myStack.Push(2);
            myStack.Push(7);
            myStack.Push(9);

            myStack.Pop();
            myStack.Pop();
            myStack.Pop();

            myStack.Log();
        }
    }
}
