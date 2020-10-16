using System;
using System.Linq;

class LobjanTranlator
{
    private static string[] lobjan = {
            "no", "pa", "re", "ci", "vo", "mu", "xa", "ze", "bi", "so"
        };

    public static void ToDecimal()
    {
        Console.Write("Lobjan: ");
        string code = Console.ReadLine();
        var decimalDigits = Enumerable.Range(0, code.Length / 2).Select(
            x => Array.IndexOf(lobjan, code.Substring(2 * x, 2))
        );
        Console.WriteLine(string.Join("", decimalDigits));
    }

    public static void ToLobjan()
    {
        Console.Write("Number: ");
        string number = Console.ReadLine();
        var lobjanDigits = number.Select(
            x => lobjan[(int)char.GetNumericValue(x)]
        );
        Console.WriteLine(string.Join("", lobjanDigits));
    }
}