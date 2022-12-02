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
                var points = 0;
                var options = line.Split(" ");
                points += GetPointsForOwnHand(options);
                points += GetPointsForResult(options[1]);
                totalPoints += points;
            }

            Console.WriteLine(totalPoints);
        }

        private static int GetPointsForResult(string result)
        {
            if (result == "X")
                return 0;
            if (result == "Y")
                return 3;
            return 6;
        }

        private static int GetPointsForOwnHand(string[] options)
        {
            if (options[1] == "X")
            {
                if (options[0] == "A")
                    return 3;
                if (options[0] == "B")
                    return 1;
                if (options[0] == "C")
                    return 2;
            }

            if (options[1] == "Y")
            {
                if (options[0] == "A")
                    return 1;
                if (options[0] == "B")
                    return 2;
                if (options[0] == "C")
                    return 3;
            }

            if (options[1] == "Z")
            {
                if (options[0] == "A")
                    return 2;
                if (options[0] == "B")
                    return 3;
                if (options[0] == "C")
                    return 1;
            }

            return default;
        }
    }
}
