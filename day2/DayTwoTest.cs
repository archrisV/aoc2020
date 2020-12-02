using System.Collections.Generic;
using Xunit;
namespace day1
{
    public class DayOneTest
    {
        [Fact]
        public void Solution_Part_One_Provided_Test()
        {
            Assert.Equal(2, DayTwo.SolutionPartOne(new List<string>() { "1-3 a: abcde", "1-3 b: cdefg", "2-9 c: ccccccccc" }));
        }
    }
}