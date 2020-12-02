using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace day2
{
    public class DayTwo
    {
        private static List<string> ParseInput() => File.ReadAllText(".\\input.txt")
                                                    .Split("\n")
                                                    .ToList();

        public static int SolutionPartOne(List<string> list)
        {
            var validPasswords = 0;
            foreach(var dataset in list)
            {
                var currentDataset = dataset.Replace(":", "").Split(" ").ToList();
                var lowerBound = Int32.Parse(currentDataset.First().Split("-").First());
                var upperBound = Int32.Parse(currentDataset.First().Split("-").Last());
                var occurances = currentDataset.Last().Count(x => x.ToString() == currentDataset[1]);
                if(lowerBound <= occurances && occurances <= upperBound)
                {
                    ++validPasswords;
                }
            }
            return validPasswords;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(SolutionPartOne(ParseInput()));
        }
    }
}