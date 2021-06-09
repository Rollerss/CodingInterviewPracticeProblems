using CodingInterviewPracticeProblems;
using System;
using Xunit;

namespace Test_CodingInterviewPracticeProblems
{
    public class Exponent_Test
    {

        [Theory]
        [InlineData(10, 0)]
        [InlineData(10, 1)]
        [InlineData(10, 2)]
        [InlineData(2, 6)]
        [InlineData(2, -1)]
        [InlineData(2.1, 3)]
        [InlineData(2.1, -2)]
        [InlineData(2.1, -3)]

        public void ShouldReturnDoubleEqualToXToPowerN(double x, int n)
        {
            var sut = new Exponent();

            double result = sut.Pow(x, n);

            Assert.Equal(Math.Pow(x, n), result);
        }
    }
}
