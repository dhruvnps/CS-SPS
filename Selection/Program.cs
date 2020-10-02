using System;
using System.Linq;
using System.Collections.Generic;

namespace Selection
{
    class Program
    {
        static void Main()
        {
            // Q5
            /*var point = new Point(-6, 4);
            Console.WriteLine(point.ToString());
            Console.WriteLine($"Quadrant {point.Quadrant()}");
            Console.WriteLine(point.DistanceFrom(new Point(-3, 0)));*/

            // BIO 2001 Q1
            /*var rhyme = new RhymeGame();
            Console.WriteLine(rhyme.Winner());*/

            // BIO 2001 Q3
            var mission = new SpaceMission();
            Console.WriteLine(mission.time);
        }
    }

    class SpaceMission
    {
        public int time;
        private List<int> astronauts = new List<int>();

        public SpaceMission()
        {
            Console.Write("Number of astronauts: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Astronaut {i + 1} time: ");
                astronauts.Add(int.Parse(Console.ReadLine()));
                astronauts.Sort();
            }
            NextTransfer();
        }

        public void NextTransfer()
        {
            int lastIndex = astronauts.Count - 1;
            if (astronauts.Count <= 2)
            {
                time += astronauts[lastIndex];
                return;
            }
            time += astronauts[0] + astronauts[lastIndex];
            astronauts.RemoveAt(lastIndex);
            if (astronauts[1] * 2 < astronauts[0] + astronauts[lastIndex - 1])
            {
                time += astronauts[1] * 2;
                astronauts.RemoveAt(lastIndex - 1);
            }
            NextTransfer();
        }
    }

    class Point
    {
        public readonly double x;
        public readonly double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public int Quadrant()
        {
            if (this.x > 0 && this.y > 0) { return 1; }
            if (this.x < 0 && this.y > 0) { return 2; }
            if (this.x < 0 && this.y < 0) { return 3; }
            if (this.x > 0 && this.y < 0) { return 4; }
            return 0;
        }

        public double DistanceFrom(Point coord)
        {
            Point shifted = new Point(this.x - coord.x, this.y - coord.y);
            return Math.Sqrt(Math.Pow(shifted.x, 2) + Math.Pow(shifted.y, 2));
        }

        public override string ToString()
        {
            return $"({this.x}, {this.y})";
        }
    }

    class RhymeGame
    {
        int friendCount;
        int wordCount;
        List<int> friends;
        int currentIndex = 0;

        public RhymeGame()
        {
            Console.Write("Number of friends: ");
            friendCount = int.Parse(Console.ReadLine());
            Console.Write("Number of words: ");
            wordCount = int.Parse(Console.ReadLine());
            friends = Enumerable.Range(1, friendCount).ToList();
        }

        public int Winner()
        {
            for (int i = 0; i < friendCount - 1; i++)
            {
                int nextIndex = (currentIndex + wordCount - 1) % friends.Count;
                friends.RemoveAt(nextIndex);
                currentIndex = nextIndex;
            }
            return friends[0];
        }
    }
}