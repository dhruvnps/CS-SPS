using System;
using System.Collections.Generic;
using System.Linq;

namespace Question6_2517
{
    class Program
    {
        static void Main()
        {
            // TaskOne();
            // TaskTwo();
            TaskExtra();
        }

        static void TaskOne()
        {
            Console.Write("Task 1, Enter decimal number: ");
            int n = int.Parse(Console.ReadLine());
            while (n >= 1)
            {
                Console.WriteLine(n % 2);
                n /= 2;
            }
        }

        static void TaskTwo()
        {
            Console.Write("Task 2, Enter decimal number: ");
            int n = int.Parse(Console.ReadLine());
            List<int> bin = new List<int>();
            while (n >= 1)
            {
                bin.Add(n % 2);
                n /= 2;
            }
            bin.Reverse();
            Console.WriteLine(String.Join("", bin));
        }

        static void TaskExtra()
        {
            Console.Write("Task Extra, Enter decimal number (-127 to 0): ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                n += 128;
                List<int> bin = new List<int>();
                while (n >= 1)
                {
                    bin.Add(n % 2);
                    n /= 2;
                }
                Console.Write(1);
                bin.Reverse();
                string binstr = String.Join("", bin);
                Console.WriteLine(binstr.PadLeft(7, '0'));
            }
            else
            {
                Console.WriteLine("00000000");
            }
        }
    }
}
