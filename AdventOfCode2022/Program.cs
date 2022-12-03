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
            var lines = File.ReadAllLines("Day3/Puzzle1.txt");

            var total = 0;
            foreach (var line in lines)
            {
                var firstString = line.Substring(0, line.Length / 2);
                var secondString = line.Substring(line.Length / 2, line.Length / 2);

                total += GetPriority(firstString, secondString);
            }

            Console.WriteLine("\n" + total);
        }

        private static int GetPriority(string firstString, string secondString)
        {
            foreach (var item in firstString.ToCharArray())
            {
                if (secondString.ToCharArray().Contains(item))
                    return GetValueForChar(item);
            }

            return default;
        }

        private static int GetValueForChar(char item)
        {
            var value = 0;
            if (char.IsUpper(item))
                value = item - 38;
            else
                value = item - 96;

            Console.WriteLine(item + " - " + value);

            return value;
        }
    }
}
