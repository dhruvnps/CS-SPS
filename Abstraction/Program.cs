using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("\nSTACK:");
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            Console.WriteLine($"Peeked: {myStack.Peek()}");
            Console.WriteLine($"Popped: {myStack.Pop()}");
            Console.WriteLine($"Popped: {myStack.Pop()}");

            Console.WriteLine("\nQUEUE:");
            //CircularQueue<int> myQueue = new CircularQueue<int>(3);
            Queue<int> myQueue = new Queue<int>();
            myQueue.Append(3);
            myQueue.Append(4);
            myQueue.Append(5);
            Console.WriteLine($"Peeked: {myQueue.Peek()}");
            Console.WriteLine($"Removed: {myQueue.Remove()}");
            Console.WriteLine($"Removed: {myQueue.Remove()}");

            Console.WriteLine("\nPOSTFIX:");
            string equation = "4 2 + 3 5 1 - * +";
            Console.WriteLine($"[{equation}] is {Postfix.Evaluate(equation)}");
            Console.WriteLine($"[{equation}] is {Postfix.GetInfix(equation)}");

            Console.WriteLine("\nLINKED LIST:");
            LinkedList<int> myLinkedList = new LinkedList<int> { 3, 1, 4, 1, 5 };

            Console.WriteLine(myLinkedList.Count);
            int[] array = new int[myLinkedList.Count];
            myLinkedList.CopyTo(array, 0);
            foreach (var item in array) Console.WriteLine(item);

            myLinkedList.Remove(4);
            myLinkedList.RemoveAt(0);
            myLinkedList.RemoveAt(0);
            myLinkedList.Insert(1, 200);
            myLinkedList.Insert(2, 100);
            foreach (var item in array) Console.WriteLine(item);

            Console.WriteLine(myLinkedList.Contains(100));
            Console.WriteLine(myLinkedList.IndexOf(100));
            foreach (var element in myLinkedList) Console.WriteLine(element);

            myLinkedList.Clear();
            Console.WriteLine(myLinkedList.Count);*/

            Console.WriteLine("\nBINARY SEARCH TREE:");
            BinarySearchTree myBST = new BinarySearchTree();
            myBST.Insert(3);
            myBST.Insert(-4);
            myBST.Insert(5);
            myBST.Inorder();
            myBST.Postorder();
            Console.WriteLine(myBST.Contains(-4));
            Console.WriteLine(myBST.Contains(20));
            myBST.Remove(-4);
            Console.WriteLine(myBST.Contains(-4));
            myBST.Inorder();
            myBST.Insert(0);
            myBST.Insert(4);
            myBST.BreadthFirst();
        }
    }
}
