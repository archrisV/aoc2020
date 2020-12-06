using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace day6
{
    public class DaySix
    {
        private static List<string> ParseInput() => File.ReadAllText(".\\input.txt")
                                                    .Split("\r\n\r\n")
                                                    .ToList();

        public static int SolutionPartOne(List<string> list)
        {
            return list.Select(x => x.Split("\r\n"))
                    .ToList()
                    .Sum(x => x.SelectMany(y => y).Distinct().Count());
        }

        public static int SolutionPartTwo(List<string> list)
        {
            return list.Select(x => x.Split("\r\n"))
                    .ToList()
                    .Sum(x => x.First().Count(y => x.All(z => z.Contains(y))));
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"Part 1 solution: {SolutionPartOne(ParseInput())}");
            Console.WriteLine($"Part 2 solution: {SolutionPartTwo(ParseInput())}");
        }
    }
}