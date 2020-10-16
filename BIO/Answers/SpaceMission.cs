using System;
using System.Linq;
using System.Collections.Generic;

namespace BIO
{
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
}