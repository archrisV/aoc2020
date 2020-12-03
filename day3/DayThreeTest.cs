using System.Collections.Generic;
using Xunit;
namespace day3
{
    public class DayThreeTest
    {
        [Fact]
        public void Solution_Part_One_Provided_Test()
        {
            Assert.Equal(7, DayThree.SolutionPartOne(new List<string>() { "..##.......",
                                                                            "#...#...#..",
                                                                            ".#....#..#.",
                                                                            "..#.#...#.#",
                                                                            ".#...##..#.",
                                                                            "..#.##.....",
                                                                            ".#.#.#....#",
                                                                            ".#........#",
                                                                            "#.##...#...",
                                                                            "#...##....#",
                                                                            ".#..#...#.#"}));
        }

        [Fact]
        public void Solution_Part_Two_Provided_Test()
        {
            Assert.Equal(336, DayThree.SolutionPartTwo(new List<string>() { "..##.......",
                                                                            "#...#...#..",
                                                                            ".#....#..#.",
                                                                            "..#.#...#.#",
                                                                            ".#...##..#.",
                                                                            "..#.##.....",
                                                                            ".#.#.#....#",
                                                                            ".#........#",
                                                                            "#.##...#...",
                                                                            "#...##....#",
                                                                            ".#..#...#.#"}));
        }

    }
}