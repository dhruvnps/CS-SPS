using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSTACK...");
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            Console.WriteLine($"Peeked: {myStack.Peek()}");
            Console.WriteLine($"Popped: {myStack.Pop()}");
            Console.WriteLine($"Popped: {myStack.Pop()}");

            Console.WriteLine("\nQUEUE...");
            //CircularQueue<int> myQueue = new CircularQueue<int>(3);
            Queue<int> myQueue = new Queue<int>();
            myQueue.Append(3);
            myQueue.Append(4);
            myQueue.Append(5);
            Console.WriteLine($"Peeked: {myQueue.Peek()}");
            Console.WriteLine($"Removed: {myQueue.Remove()}");
            Console.WriteLine($"Removed: {myQueue.Remove()}");
            Console.WriteLine($"Removed: {myQueue.Remove()}");

            Console.WriteLine("\nPOSTFIX...");
            string equation = "4 2 + 3 5 1 - * +";
            Console.WriteLine($"[{equation}] is {Postfix.Evaluate(equation)}");
            Console.WriteLine($"[{equation}] is {Postfix.GetInfix(equation)}");
        }
    }
}
