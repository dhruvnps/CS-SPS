using System;

namespace BIO
{
    class Program
    {
        static void Main()
        {
            // BIO 2001 Q1
            /*var rhyme = new RhymeGame();
            Console.WriteLine(rhyme.Winner());*/

            // BIO 2001 Q3
            var mission = new SpaceMission();
            Console.WriteLine(mission.time);

            // BIO 2003 Q1
            /*ISBN.MissingDigit();
            ISBN.SwappedDigit();*/

            // BIO 2003 Q3
            NewOrder.Run();

            // BIO 2000 Q1:
            /*Password.CheckPassword();*/

            // BIO 2002 Q1:
            /*LobjanTranlator.ToDecimal();
            LobjanTranlator.ToLobjan();*/

            // BIO 2004 Q1
            /*var mayan = new MayanDateTime(MayanDateTime.InputValues());
            DateTime dt = mayan.ToDateTime();
            Console.WriteLine($"{dt.Day} {dt.Month} {dt.Year}");*/
        }
    }
}
