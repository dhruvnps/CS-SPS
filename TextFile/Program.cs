using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TextFile
{
    class Program
    {
        static void Main()
        {
            // Sentences.Write();
            RandomList.Write(length: 10, limit: 500);
            RandomList.WriteSorted(length: 10, limit: 500);
        }
    }

    class Sentences
    {
        static public void Write()
        {
            StreamWriter file = File.AppendText("sentences.txt");
            while (true)
            {
                Console.Write("Enter Sentence: ");
                string line = Console.ReadLine();
                if (line == "") break;
                file.WriteLine(line);
            }
            file.Close();
        }
    }

    class RandomList
    {
        static public void Write(int length, int limit)
        {
            StreamWriter file = File.CreateText("unsorted.txt");
            var rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                file.WriteLine(rnd.Next(1, limit));
            }
            file.Close();
        }

        /*static public void WriteSorted(int length, int limit)
        {
            StreamWriter file = File.CreateText("sorted.txt");
            var rnd = new Random();
            Sort.QuickSort(
                Enumerable
                  .Range(0, length)
                  .Select(x => rnd.Next(0, limit))
                  .ToList()
            ).ForEach(
                x => file.WriteLine(x)
            );
            file.Close();
        }*/
    }

    class Sort
    {
        static public List<int> QuickSort(List<int> list, int high = -1, int low = 0)
        {
            if (high == -1) high = list.Count - 1;
            if (low < high)
            {
                int pivot = list[high];
                int i = low;
                for (int j = low; j <= high; j++)
                {
                    if (list[j] < pivot)
                    {
                        var temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                        i++;
                    }
                }
                QuickSort(list, i - 1, low);
                QuickSort(list, high, i + 1);
            }
            return list;
        }
    }
}
