using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace day4
{
    public class DayFour
    {
        private static List<string> ParseInput() => File.ReadAllText(".\\input.txt")
                                                    .Split("\n\n")
                                                    .ToList();

        public static int SolutionPartOne(List<string> list)
        {

        }

        /*public static int SolutionPartTwo(List<string> list)
        {
    
        }*/

        public static void Main(string[] args)
        {
            Console.WriteLine($"Part 1 solution: {SolutionPartOne(ParseInput())}");
            //Console.WriteLine($"Part 2 solution: {SolutionPartTwo(ParseInput())}");
        }
    }
}