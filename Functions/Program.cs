using System;
using System.Linq;

namespace Functions
{
    class Program
    {
        static void Main()
        {
            // Functions Questions
            Console.WriteLine(MyMath.Sum(1, 2, 4));
            Console.WriteLine(MyMath.Sum(0.2, 4.74));
            Console.WriteLine(MyMath.SumDigits(123));
            Console.WriteLine("53 is " + (MyMath.IsPrime(53) ? "" : "not ") + "prime");

            (int a, int b) = (1, 4);
            Console.Write($"before: a = {a}, b = {b} | ");
            MyFuncs.Swap<int>(ref a, ref b);
            Console.WriteLine($"after: a = {a}, b = {b}");

            Console.WriteLine(MyFuncs.LetterCount(text: "hi hello world", letter: ' '));
            Console.WriteLine(MyFuncs.BinHexInfo(123));

            // BIO 2004 Q1
            int[] mayanDateInputs = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write(MayanDateTime.names[i] + ": ");
                mayanDateInputs[i] = int.Parse(Console.ReadLine());
            }
            var mayan = new MayanDateTime(mayanDateInputs);
            DateTime dt = mayan.ToDateTime();
            Console.WriteLine($"{dt.Day} {dt.Month} {dt.Year}");
        }
    }

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
            // is this cheating?
            int daysSince2000 = MayanToDays(mayanNow) - MayanToDays(mayan2000);
            return new DateTime(2000, 1, 1).AddDays(daysSince2000);
        }
    }

    class MyMath
    {
        static public int Sum(params int[] nums)
        {
            int sum = 0;
            Array.ForEach(nums, num => sum += num);
            return sum;
        }

        static public double Sum(params double[] nums)
        {
            double sum = 0;
            Array.ForEach(nums, num => sum += num);
            return sum;
        }

        static public int SumDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num = (int)(num / 10);
            }
            return sum;
        }

        static public bool IsPrime(int num)
        {
            if (num == 2 || num == 3) return true;
            if (num < 2 || num % 2 == 0) return false;
            int sqrt = (int)(Math.Sqrt(num));
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }

    class MyFuncs
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }

        public static int LetterCount(string text, char letter)
        {
            return text.Count(x => (x == letter));
        }

        public static string BinHexInfo(int num)
        {
            return $"Bin: {Convert.ToString(num, 2)} Hex: {Convert.ToString(num, 16)}";
        }
    }

}