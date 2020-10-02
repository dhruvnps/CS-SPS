using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            // Q1:
            /*var race = new Race();
            Console.WriteLine(Math.Round(race.Speed(), 2) + " m/s");
            Console.WriteLine(Math.Round(race.SpeedMPH(), 2) + " mph");*/

            // Q2:
            /*TimesTable.PrintTable(3);*/

            // Q3:
            /*var circle = new Circle(radius: 5);
            Console.WriteLine("Area: " + Math.Round(circle.area, 2));*/

            // BIO 2000 Q1:
            Password.CheckPassword();

            // BIO 2002 Q1:
            LobjanTranlator.ToDecimal();
            LobjanTranlator.ToLobjan();
        }
    }

    class Race
    {
        float minutes;
        float seconds;
        float kilometers;

        public Race()
        {
            Console.Write("Minutes: ");
            minutes = float.Parse(Console.ReadLine());
            Console.Write("Seconds: ");
            seconds = float.Parse(Console.ReadLine());
            Console.Write("Kilometers: ");
            kilometers = float.Parse(Console.ReadLine());
        }

        public float Speed()
        {
            float totalSeconds = minutes * 60 + seconds;
            float totalMeters = kilometers * 1000;
            return totalMeters / totalSeconds;
        }

        public float SpeedMPH() { return Speed() * 2.23694f; }
    }

    class TimesTable
    {
        public static void PrintTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i * number);
            }
        }
    }

    class Circle
    {
        public readonly double radius;
        public readonly double area;
        public Circle(double radius)
        {
            this.radius = radius;
            this.area = 2 * Math.PI * radius;
        }
    }

    class Password
    {
        public static void CheckPassword()
        {
            Console.Write("Password: ");
            string password = Console.ReadLine().ToUpper();
            Console.WriteLine(Password.IsValid(password) ? "Accepted" : "Rejected");
        }

        private static bool IsValid(string password)
        {
            for (int len = 1; len <= password.Length - 1; len++)
            {
                for (int pos = 0; pos < password.Length - (len * 2 - 1); pos++)
                {
                    if (password.Substring(pos, len) == password.Substring(pos + len, len))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

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
}