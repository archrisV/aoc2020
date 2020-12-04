using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace day4
{
    public class DayFour
    {
        private static List<string> ParseInput() => File.ReadAllText(".\\input.txt")
                                                    .Split("\r\n\r\n")
                                                    .ToList();

        public static int SolutionPartOne(List<string> list)
        {
            var keys = new List<string>(){ "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid"};
            var validPassports = 0;
            list.ForEach(x => x.Replace("\n", " "));
            foreach(var passport in list)
            {
                if(keys.Where(x => passport.Contains(x)).Count() == 7)
                {
                    validPassports++;
                }
            }
            return validPassports;
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