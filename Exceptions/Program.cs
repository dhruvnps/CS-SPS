using System;

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Sqrt());
        }

        static public double Sqrt()
        {
            double x = 0.0;
            Console.Write("Number: ");
            try
            {
                x = double.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("No");
            }
            return x;
        }
    }
}
