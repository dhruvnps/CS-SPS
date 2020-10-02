using System;
using System.Linq;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main()
        {
            // TimesTable.Print(number: 12, columns: 12);
            // Console.WriteLine(MyMath.Triangular(4));
            // MyMath.Ask10();

            // BIO 2003 Q1
            ISBN.MissingDigit();
            ISBN.SwappedDigit();

            // BIO 2003 Q3
            // NewOrder.Run();
        }
    }

    class NewOrder
    {
        public static void Run()
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m: ");
            int m = int.Parse(Console.ReadLine()); ;

            int c = 1;
            if (m == 0) Console.WriteLine("0");
            else Count(n, ref c, Enumerable.Range(1, m).ToArray(), 30, m);
        }

        public static void Count(int n, ref int c, int[] pos, int max, int scope)
        {
            if (c < n && scope > 0)
            {
                for (int i = pos[scope - 1] + 1; i <= max; i++)
                {
                    c++;
                    int[] newPos = pos.ToArray();
                    newPos[scope - 1] = i;
                    Count(n, ref c, newPos, i - 1, scope - 1);
                }
            }
            else if (c == n) PrintAsBinary(pos);
        }

        private static void PrintAsBinary(int[] pos)
        {
            for (int i = pos.Last(); i >= 1; i--)
            {
                Console.Write(pos.Contains(i) ? '1' : '0');
                if ((pos.Last() - i + 1) % 6 == 0) Console.Write(' ');
            }
            Console.WriteLine();
        }
    }

    class ISBN
    {
        static private bool IsValid(string code)
        {
            var arr = code.Select((x, i) => (x == 'X' ? 10 : x - 48) * (10 - i));
            return arr.Sum() % 11 == 0;
        }

        static public void MissingDigit()
        {
            Console.Write("ISBN Missing: ");
            string code = Console.ReadLine();
            char digit = 'X';
            for (char i = '0'; i <= '9'; i++)
            {
                if (IsValid(code.Replace('?', i)))
                {
                    digit = i;
                    break;
                }
            }
            Console.WriteLine("Missing Digit: " + digit);
        }

        static public void SwappedDigit()
        {
            Console.Write("ISBN Swapped: ");
            string code = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    char[] arr = code.ToArray();
                    char temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    if (IsValid(new string(arr)))
                    {
                        Console.WriteLine("Corrected Code: " + new string(arr));
                    }
                }
            }
        }
    }

    class TimesTable
    {
        static public void Print(int number, int columns)
        {
            for (int i = 1; i <= columns; i++)
            {
                int padding = columns.ToString().Length - i.ToString().Length;
                Console.WriteLine($"{number} * {new string('0', padding)}{i} = {number * i}");
            }
        }
    }

    class MyMath
    {
        static public void Ask10()
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + ": ");
                total += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Average: " + ((float)total / 10));
        }

        static public int Triangular(int n)
        {
            return (n / 2) * (n + 1);
        }
    }
}