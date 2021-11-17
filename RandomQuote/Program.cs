using System;
using System.IO;

namespace RandomQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(RandomLineFromFile());
            }


        }

        private static string RandomLineFromFile()
        {
            string filePath = @"C:\Users\opilane\Samples\randomquote.txt";

            string[] dataFromFile = File.ReadAllLines(filePath);

            Console.WriteLine(dataFromFile[0]);

            Random rnd = new Random();
            int randomIndex = rnd.Next(1, dataFromFile.Length);

            return dataFromFile[randomIndex];
        }
    }
}
