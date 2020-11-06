using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(2);
            myStack.Push(9);
            myStack.Log();
            Console.WriteLine($"Popped: {myStack.Pop()}");
            Console.WriteLine($"Popped: {myStack.Pop()}");

            string equation = "1 2 3 4 5 - + * /";
            float value = Postfix.Evaluate(equation);
            Console.WriteLine($"[{equation}] is {value}");
        }
    }
}
