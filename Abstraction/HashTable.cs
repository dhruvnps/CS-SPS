using System;

class HashTable
{
    private static uint GetHash(string key)
    {
        uint hash = 5381;
        uint i = 0;

        for (i = 0; i < key.Length; i++)
        {
            hash = ((hash << 5) + hash) + ((byte)key[(int)i]);
        }

        return hash;
    }

    public static void Test()
    {
        Console.WriteLine(GetHash("56789"));
    }
}
