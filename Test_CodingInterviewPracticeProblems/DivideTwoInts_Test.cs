using CodingInterviewPracticeProblems;
using Xunit;

namespace Test_CodingInterviewPracticeProblems
{
    public class DivideTwoInts_Test
    {
        [Theory]
        [InlineData(1, 2, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(11, 2, 5)]
        [InlineData(111, 10, 11)]

        public void ShouldReturnIntDivided(int num1, int num2, int answer)
        {
            var sut = new DivideTwoInts();

            int result = sut.DivideTheLongWay(num1, num2);

            Assert.Equal(answer, result);
        }
    }
}
