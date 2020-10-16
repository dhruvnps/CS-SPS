using System;
using System.Collections.Generic;
using System.Linq;

namespace BIO
{
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
