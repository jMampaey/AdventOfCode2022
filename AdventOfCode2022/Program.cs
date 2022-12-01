using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

            var elves = new List<int>();
            var elfTotal = 0;

            foreach(var line in lines)
            {
                if (line == "")
                {
                    elves.Add(elfTotal);
                    elfTotal = 0;
                    continue;
                }
                var value = Int32.Parse(line);
                elfTotal += value;
            }

            var total = 0;
            foreach (var elf in elves.OrderByDescending(e => e).Take(3))
            {
                total += elf;
                Console.WriteLine(elf);
            }

            Console.WriteLine("\n" + total);

        }
    }
}
