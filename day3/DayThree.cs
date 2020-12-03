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

        public static int SolutionPartOne(List<string> list, int right, int down)
        {   
            int trees = 0;
            var mapWidth = list.First().Length;
            for(var i = 0; i < list.Count; i += down)
            {
                if(list[i][i * right % mapWidth] == '#')
                {
                    ++trees;
                }
            }
            return trees;
        }

        /*public static int SolutionPartTwo(List<string> list)
        {

        }*/

        public static void Main(string[] args)
        {
            Console.WriteLine($"Part 1 solution: {SolutionPartOne(ParseInput(), 3, 1)}");
            //Console.WriteLine($"Part 2 solution: {SolutionPartTwo(ParseInput())}");
        }
    }
}