using System;

namespace BIO
{
    class Program
    {
        static void Main()
        {
            // BIO_2001_Q3();
            // BIO_2003_Q3();

            // BIO_2001_Q1();
            // BIO_2003_Q1();
            // BIO_2000_Q1();
            // BIO_2002_Q1();
            // BIO_2004_Q1();
            BIO_2019_Q1();
        }

        static void BIO_2001_Q1()
        {
            var rhyme = new RhymeGame();
            Console.WriteLine(rhyme.Winner());
        }

        static void BIO_2001_Q3()
        {
            var mission = new SpaceMission();
            Console.WriteLine(mission.time);
        }

        static void BIO_2003_Q1()
        {
            ISBN.MissingDigit();
            ISBN.SwappedDigit();
        }

        static void BIO_2003_Q3()
        {
            NewOrder.Run();
        }

        static void BIO_2000_Q1()
        {
            Password.CheckPassword();
        }

        static void BIO_2002_Q1()
        {
            LobjanTranlator.ToDecimal();
            LobjanTranlator.ToLobjan();
        }

        static void BIO_2004_Q1()
        {
            var mayan = new MayanDateTime(MayanDateTime.InputValues());
            DateTime dt = mayan.ToDateTime();
            Console.WriteLine($"{dt.Day} {dt.Month} {dt.Year}");
        }

        static void BIO_2019_Q1()
        {
            Palendrome.SmallestAbove();
        }
    }
}
