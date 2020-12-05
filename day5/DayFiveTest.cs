using System.Collections.Generic;
using Xunit;
namespace day5
{
    public class DayFiveTest
    {
        [Fact]
        public void Solution_Part_One_Provided_Test()
        {
            Assert.Equal(820, DayFive.SolutionPartOne(new List<string>() { "BFFFBBFRRR",
                                                                            "FFFBBBFRRR",
                                                                            "BBFFBBFRLL"}));
        }

        [Fact]
        public void Solution_Part_Two_Provided_Test()
        {
            Assert.Equal(820, DayFive.SolutionPartOne(new List<string>() { "BFFFBBFRRR",
                                                                            "FFFBBBFRRR",
                                                                            "BBFFBBFRLL"}));
        }
    }
}