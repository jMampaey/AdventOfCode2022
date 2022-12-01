using System;
using System.IO;

namespace AdventOfCode2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.PrintFile();
        }

        private static void PrintFile()
        {
            var lines = File.ReadAllLines("Day1/Puzzle1.txt");
            var currentElf = 1;
            int biggestElf = default;
            var elfTotal = 0;
            var biggestTotal = 0;

            foreach(var line in lines)
            {
                if (line == "")
                {
                    Console.WriteLine(currentElf + " - " + elfTotal);
                    if (elfTotal > biggestTotal)
                    {
                        biggestTotal = elfTotal;
                        biggestElf = currentElf;
                    }    

                    currentElf++;
                    elfTotal = 0;
                    continue;
                }
                var value = Int32.Parse(line);
                elfTotal += value;
            }

            Console.WriteLine();
            Console.WriteLine(biggestElf + " - " + biggestTotal);
        }
    }
}
