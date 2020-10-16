using System;
using System.Linq;

class MayanDateTime
{
    public static string[] names = { "baktun", "katun", "tun", "uinal", "kin" };

    private int[] mayanNow = new int[5];
    private int[] mayan2000 = { 13, 20, 7, 16, 3 };

    private int[] values = {
            20 * 20 * 18 * 20,
            20 * 18 * 20,
            18 * 20,
            20,
            1
        };

    public MayanDateTime(int[] mayanNow)
    {
        this.mayanNow = mayanNow;
    }

    private int MayanToDays(int[] mayan)
    {
        return mayan.Select((x, index) => x * values[index]).Sum();
    }

    public DateTime ToDateTime()
    {
        int daysSince2000 = MayanToDays(mayanNow) - MayanToDays(mayan2000);
        return new DateTime(2000, 1, 1).AddDays(daysSince2000);
    }

    public static int[] InputValues()
    {
        int[] mayanDateInputs = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write(MayanDateTime.names[i] + ": ");
            mayanDateInputs[i] = int.Parse(Console.ReadLine());
        }
        return mayanDateInputs;
    }
}