using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { -1, 1, -4, 4, 7, 8 };

            // Iterative Functions:
            Console.WriteLine($"Sum: {Iterative.Sum(list)}");
            Console.WriteLine($"Max: {Iterative.Max(list)}");
            Console.WriteLine($"Min: {Iterative.Min(list)}");
            Iterative.Negatives(list).ForEach(x => Console.WriteLine(x));
        }
    }

    class Iterative
    {
        static public int Sum(List<int> list)
        {
            int sum = 0;
            foreach (int n in list)
            {
                sum += n;
            }
            return sum;
        }

        static public int Max(List<int> list)
        {
            int max = list[0];
            foreach (int n in list)
            {
                if (n > max) max = n;
            }
            return max;
        }

        static public int Min(List<int> list)
        {
            int min = list[0];
            foreach (int n in list)
            {
                if (n < min) min = n;
            }
            return min;
        }

        static public List<int> Negatives(List<int> list)
        {
            List<int> values = new List<int>();
            foreach (int n in list)
            {
                if (n < 0) values.Add(n);
            }
            return values;
        }
    }
}
