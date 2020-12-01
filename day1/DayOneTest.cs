using System.Collections.Generic;
using Xunit;
namespace day1
{
    public class DayOneTest
    {
        [Fact]
        public void Solution_Part_One_Provided_Test()
        {
            Assert.Equal(514_579, DayOne.SolutionPartOne(new List<int>() { 1721, 979, 366, 299, 675, 1456 }));
        }

        [Fact]
        public void Solution_Part_One_Selfmade_Test()
        {
            Assert.Equal(1_007_104, DayOne.SolutionPartOne(new List<int>() { 333, 1284, 2021, 1124, 896 }));
        }
        [Fact]
        public void Solution_Part_Two_Provided_Test()
        {
            Assert.Equal(241_861_950, DayOne.SolutionPartTwo(new List<int>() { 1721, 979, 366, 299, 675, 1456, 366, 675 }));
        }
        [Fact]
        public void Solution_Part_Two_Selfmade_Test()
        {
            Assert.Equal(282_703_590, DayOne.SolutionPartTwo(new List<int>() { 333, 1284, 2021, 1124, 896, 485, 689, 846}));
        }

    }
}