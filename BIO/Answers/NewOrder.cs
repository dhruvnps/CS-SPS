using System;
using System.Linq;

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