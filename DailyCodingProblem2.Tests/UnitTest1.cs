using System;
using Xunit;
using DailyCodingProblem2;

namespace DailyCodingProblem2.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 120, 60, 40, 30, 24 })]
        [InlineData(new int[] { 3, 2, 1 }, new int[] { 2, 3, 6 })]
        public void Test_product_outcome(int[] input, int[] expectedResult)
        {
            var result = Program.GetProduct(input);

            Assert.Equal(expectedResult, result);
        }
    }
}
