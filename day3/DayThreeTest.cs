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
                                                                            ".#..#...#.#"}, 3, 1));
        }

    }
}