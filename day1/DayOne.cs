using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace day1
{
    public class DayOne
    {
        public const int targetYear = 2020;
        private static List<int> ParseInput() => File.ReadAllText(".\\input.txt")
                                                    .Split("\n")
                                                    .Select(x => Int32.Parse(x))
                                                    .ToList();

        public static long SolutionPartOne(List<int> list)
        {
            long target = 0;
            foreach (var x in list)
            {
                if (list.Contains(targetYear - x))
                {
                    target = (targetYear - x) * x;
                    break;
                }
            }
            return target;
        }

        public static long SolutionPartTwo(List<int> list)
        {
            long target = 0;
            foreach (var x in list)
            {
                var remainder = targetYear - x;
                foreach (var y in list.Where(t => t < remainder).ToList())
                {
                    if (y == x)
                    {
                        continue;
                    }
                    if (list.Contains(remainder - y))
                    {
                        target = (remainder - y) * x * y;
                        break;
                    }
                }
            }
            return target;
        }
        public static void Main(string[] args)
        {
            var list = ParseInput();
            Console.WriteLine($"Solution for part 1: {SolutionPartOne(list)}");
            Console.WriteLine($"Solution for part 2: {SolutionPartTwo(list)}");
        }
    }
}