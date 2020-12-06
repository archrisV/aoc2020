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

        public static List<int> SolutionPartOne(List<string> list)
        {
            
        }

        /*public static int SolutionPartTwo(List<int> list)
        {
            return Enumerable.Range(list.Min(), list.Max()).Except(list.OrderBy(x => x).ToList()).First();

        }*/

        public static void Main(string[] args)
        {
            Console.WriteLine($"Part 1 solution: {SolutionPartOne(ParseInput())}");
            //Console.WriteLine($"Part 2 solution: {SolutionPartTwo(SolutionPartOne(ParseInput()))}");
        }
    }
}