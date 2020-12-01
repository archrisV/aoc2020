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

        public static void Main(string[] args)
        {
            var list = ParseInput();
            long target = 0;
            foreach (var x in list)
            {
                if(list.Contains(targetYear - x))
                {
                    target = (targetYear - x) * x;
                    break;
                }
            }
            Console.WriteLine(target);
        }
    }
}