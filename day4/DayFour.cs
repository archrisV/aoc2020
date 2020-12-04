using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Text.RegularExpressions;

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

        public static int SolutionPartTwo(List<string> list)
        {
            var keys = new List<string>(){ "byr:", "iyr:", "eyr:", "hgt:", "hcl:", "ecl:", "pid:"};
            var validPassports = 0;
            foreach(var ps in list)
            {
                var passport = ps.Replace("\r\n", " ");
                if(keys.Where(x => passport.Contains(x)).Count() == 7)
                {
                    var details = passport.Split(" ").ToList();

                        if (IsBirthYearValid(Int32.Parse(details.Where(x => x.Contains(keys[0])).First().Replace(keys[0], ""))) &&
                        IsIssueYearValid(Int32.Parse(details.Where(x => x.Contains(keys[1])).First().Replace(keys[1], ""))) &&
                        IsExpirationYearValid(Int32.Parse(details.Where(x => x.Contains(keys[2])).First().Replace(keys[2], ""))) &&
                        IsHeightValid(details.Where(x => x.Contains(keys[3])).First().Replace(keys[3], "")) &&
                        IsHairColorValid(details.Where(x => x.Contains(keys[4])).First().Replace(keys[4], "")) &&
                        IsEyeColorValid(details.Where(x => x.Contains(keys[5])).First().Replace(keys[5], "")) &&
                        IsPIDValid(details.Where(x => x.Contains(keys[6])).First().Replace(keys[6], "")))
                        {
                            validPassports++;
                        }
                }
            }
            return validPassports;
        }
        public static List<string> VALIDEYECOLORS = new List<string>() { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
        public static Regex VALIDHAIRCOLORS = new Regex(@"#([a-f]|[0-9]){6}");
        public static Regex VALIDPID = new Regex(@"^[0-9]{9}$");
        public static bool IsBirthYearValid(int year) => year >= 1920 && year <= 2002; 
        public static bool IsIssueYearValid(int year) => year >= 2010 && year <= 2020; 
        public static bool IsExpirationYearValid(int year) => year >= 2020 && year <= 2030;
        public static bool IsEyeColorValid(string color) => VALIDEYECOLORS.Contains(color);
        public static bool IsHairColorValid(string color) => VALIDHAIRCOLORS.IsMatch(color);
        public static bool IsPIDValid(string pid) => VALIDPID.IsMatch(pid);

        public static bool IsHeightValid(string heigth)
        {
            if(heigth.Contains("in"))
            {
                var h = Int32.Parse(heigth.Replace("in", ""));
                return h >= 59 && h <= 76;
            }
            else if(heigth.Contains("cm"))
            {
                var h = Int32.Parse(heigth.Replace("cm", ""));
                return h >= 150 && h <= 193;
            }
            return false;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine($"Part 1 solution: {SolutionPartOne(ParseInput())}");
            Console.WriteLine($"Part 2 solution: {SolutionPartTwo(ParseInput())}");
        }
    }
}