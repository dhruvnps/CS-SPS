using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            Console.WriteLine($"Popped: {myStack.Pop()}");
            Console.WriteLine($"Popped: {myStack.Pop()}");

            Queue<int> myQueue = new Queue<int>();
            myQueue.Append(3);
            myQueue.Append(4);
            myQueue.Append(5);
            Console.WriteLine($"Removed: {myQueue.Remove()}");
            Console.WriteLine($"Removed: {myQueue.Remove()}");
            Console.WriteLine($"Removed: {myQueue.Remove()}");

            string equation = "1 2 3 4 5 - + * /";
            float value = Postfix.Evaluate(equation);
            Console.WriteLine($"[{equation}] is {value}");
        }
    }
}
