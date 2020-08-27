using System;
using Xunit;
using Challenges;
using System.Runtime;

namespace Challenges.Test
{
    public class SystemIOTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 4, 5 }, 8)]
        [InlineData(new int[] { 1, 3, 5 }, 15)]
        [InlineData(new int[] { 1, 2 }, 0)]
        public void TestProductOfArray(int[] numberArray, int expected)
        {
            // Act
            int result = Program.ProductOfArray(numberArray);
            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1 2 3", new int[] { 1, 2, 3 })]
        [InlineData("1 g 5", new int[] { 1, 1, 5 })]

        public void TestConvertStringToNumbers(string input, int[] expected)
        {
            // Arrange

            // Act
            int[] result = Program.ConvertStringToNumbers(input);
            // Assert
            Assert.Equal(expected, result);
        }
    }   
}
