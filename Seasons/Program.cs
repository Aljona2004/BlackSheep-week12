using System;
using System.IO;

namespace Seasons
{
    class Program
    {
        static void Main(string[] args)
        {
            string autumnFile = @"C:\Users\opilane\Samples\autumn.txt";
            string winterFile = @"C:\Users\opilane\Samples\winter.txt";

            string[] winterData = File.ReadAllLines(autumnFile);
            string[] autumnData = File.ReadAllLines(winterFile);

            File.WriteAllLines(autumnFile, autumnData );
            File.WriteAllLines(winterFile, winterData);
        }
    }
}
