using System.Collections.Generic;
using Xunit;
namespace day2
{
    public class DayTwoTest
    {
        [Fact]
        public void Solution_Part_One_Provided_Test()
        {
            Assert.Equal(2, DayTwo.SolutionPartOne(new List<string>() { "1-3 a: abcde", "1-3 b: cdefg", "2-9 c: ccccccccc" }));
        }

        [Fact]
        public void Solution_Part_Two_Provided_Test()
        {
            Assert.Equal(1, DayTwo.SolutionPartTwo(new List<string>() { "1-3 a: abcde", "1-3 b: cdefg", "2-9 c: ccccccccc" }));
        }
    }
}