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

            // Search Functions:
            list.Sort();
            Console.WriteLine(Search.Binary(list, 1));
            Console.WriteLine(Search.Binary(list, 2));
            Console.WriteLine(Search.Linear(list, 1));
            Console.WriteLine(Search.Linear(list, 2));
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

    class Search
    {
        static public bool Linear(List<int> list, int item)
        {
            foreach (int n in list)
            {
                if (n == item) return true;
            }
            return false;
        }

        static public bool Binary(List<int> list, int item)
        {
            int min = 0;
            int max = list.Count - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (item < list[mid])
                {
                    max = mid - 1;
                }
                else if (item > list[mid])
                {
                    min = mid + 1;
                }
                else return true;
            }
            return false;
        }
    }

    class Sort
    {
        /*static public List<int> Quick(List<int> list, int low = 0, int high = -1)
        {
            if (high == -1) high = list.Count;
            if (low < high)
            {
                int p = Partition(List, low, high);
                Quick(list, low, p - 1);
                Quick(list, p + 1, high);
            }
            return list;
        }*/
    }
}
