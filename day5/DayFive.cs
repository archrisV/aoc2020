using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace day5
{
    public class DayFive
    {
        private static List<string> ParseInput() => File.ReadAllText(".\\input.txt")
                                                    .Split("\r\n")
                                                    .ToList();

        public static List<int> SolutionPartOne(List<string> list)
        {
            var seatIDs = new List<int>();
            foreach (string boardingPass in list) 
            {
                int minCol = 0;
                int maxCol = 127;
                int minRow = 0;
                int maxRow = 7;
                foreach(var tag in boardingPass) 
                {
                    switch(tag){
                        case 'F':
                            maxCol = (maxCol + minCol) / 2;
                            break;
                        case 'B':
                            minCol = (int)Math.Ceiling((decimal)(maxCol + minCol) / 2);
                            break;
                        case 'L':
                            maxRow = (maxRow + minRow) / 2;
                            break;
                        case 'R':
                            minRow = (int)Math.Ceiling((decimal)(maxRow + minRow) / 2);
                            break;
                        default:
                            throw new Exception($"Invalid tag in the boarding pass {boardingPass}");
                    }
                }
                seatIDs.Add(maxCol * 8 + maxRow);
            }
            return seatIDs;
        }

        public static int SolutionPartTwo(List<int> list)
        {
            return Enumerable.Range(list.Min(), list.Max()).Except(list.OrderBy(x => x).ToList()).First();

        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"Part 1 solution: {SolutionPartOne(ParseInput()).Max()}");
            Console.WriteLine($"Part 2 solution: {SolutionPartTwo(SolutionPartOne(ParseInput()))}");
        }
    }
}