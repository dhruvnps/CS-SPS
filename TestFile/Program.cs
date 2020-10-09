using System;
using System.IO;

namespace TestFile
{
    class Program
    {
        static void WriteSentences()
        {
            string nextLine;
            string myFile = "sentences.txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myFile = Path.Combine(docPath, myFile);
            StreamWriter fileStr = File.CreateText(myFile);

            do
            {
                Console.WriteLine("Enter next sentence: ");
                nextLine = Console.ReadLine();
                if (nextLine != "")
                {
                    fileStr.WriteLine(nextLine);
                }
            } while (nextLine != "");
            fileStr.Close();
        }

        static void Main()
        {
            Console.WriteLine("File manipulation");
            WriteSentences();
        }
    }

}
