using System;
using System.Linq;

class Palendrome
{
    public static void SmallestAbove()
    {
        Console.Write("Value: ");
        ulong min = ulong.Parse(Console.ReadLine());
        ulong val = min;
        ulong folded;
        while (Fold(val, out folded) <= min)
            val += (ulong)Math.Pow(10, (int)(Math.Log10(val) + 1) / 2);
        Console.WriteLine(folded);
    }

    static ulong Fold(ulong val, out ulong folded)
    {
        char[] array = val.ToString().ToArray();
        var first = array[0..^(array.Length / 2)];
        var last = array[0..(array.Length / 2)];
        Array.Reverse(last);
        return folded = ulong.Parse(String.Join("", first.Concat(last)));
    }
}