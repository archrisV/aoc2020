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
            var input = list.Select(x => x.Split("\r\n")).ToList();
            return input.Sum(x => x.SelectMany(y => y).Distinct().Count());
        }

        /*public static int SolutionPartTwo(List<int> list)
        {

        }*/

        public static void Main(string[] args)
        {
            Console.WriteLine($"Part 1 solution: {SolutionPartOne(ParseInput())}");
            //Console.WriteLine($"Part 2 solution: {SolutionPartTwo(ParseInput())}");
        }
    }
}