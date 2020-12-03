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

        public static int SolutionPartOne(List<string> list)
        {
            
        }

        /*public static int SolutionPartTwo(List<string> list)
        {

        }*/

        /*public static void Main(string[] args)
        {
            Console.WriteLine($"Part 1 solution: {SolutionPartOne(ParseInput())}");
            Console.WriteLine($"Part 2 solution: {SolutionPartTwo(ParseInput())}");
        }*/
    }
}