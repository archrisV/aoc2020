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
                var remainder = targetYear - x;
                foreach (var y in list)
                {
                    if (y == x)
                    {
                        continue;
                    }
                    if(list.Contains(remainder - y))
                    {
                        target = (remainder - y) * x * y;
                        break;
                    }
                }
            }
            Console.WriteLine(target);
        }
    }
}