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
            Console.Write("Number: ");
            try
            {
                double x = double.Parse(Console.ReadLine());
                return Math.Sqrt(x);
            }
            catch (System.Exception)
            {
                Console.WriteLine("No");
            }
            finally
            {
            }
        }
    }
}
