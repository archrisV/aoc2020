using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace day3
{
    public class DayThree
    {
        private static List<string> ParseInput() => File.ReadAllText(".\\input.txt")
                                                    .Split("\n")
                                                    .ToList();

        public static int SolutionPartOne(List<string> list, int right = 3, int down = 1)
        {
            return list
                .Where((row, i) => i % down == 0 && row[(right * (i / down)) % row.Length] == '#')
                .Count();
        }

        public static double SolutionPartTwo(List<string> list)
        {
            var pairs = new List<(int, int)>()
            {
                (1, 1),
                (3, 1),
                (5, 1),
                (7, 1),
                (1, 2)
            };
            return pairs.Select(x => SolutionPartOne(list, x.Item1, x.Item2))
                        .Aggregate(1, (x, y) => x * y);

        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"Part 1 solution: {SolutionPartOne(ParseInput())}");
            Console.WriteLine($"Part 2 solution: {SolutionPartTwo(ParseInput())}");
        }
    }
}