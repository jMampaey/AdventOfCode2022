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
            var lines = File.ReadAllLines("Day2/Puzzle1.txt");

            var totalPoints = 0;

            foreach(var line in lines)
            {
                var newLine = line.Replace("X", "A");
                newLine = newLine.Replace("Y", "B");
                newLine = newLine.Replace("Z", "C");

                var points = 0;
                var options = newLine.Split(" ");
                Console.WriteLine(options[0] + " - " + options[1]);
                points += GetPointsForOwnHand(options[1]);
                points += GetPointsForResult(options);
                totalPoints += points;
            }

            Console.WriteLine(totalPoints);
        }

        private static int GetPointsForResult(string[] options)
        {
            if ((options[0] == "A" && options[1] == "B") || (options[0] == "B" && options[1] == "C") || (options[0] == "C" && options[1] == "A"))
                return 6;
            if (options[0] == options[1])
                return 3;
            return 0;
        }

        private static int GetPointsForOwnHand(string value)
        {
            if (value == "A")
                return 1;
            if (value == "B")
                return 2;
            if (value == "C")
                return 3;

            return default;
        }
    }
}
