using System;
using System.Linq;

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