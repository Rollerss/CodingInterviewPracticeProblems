using CodingInterviewPracticeProblems;
using Xunit;

namespace Test_CodingInterviewPracticeProblems
{
    public class AddNonIntsAsInts_Test
    {
        [Theory]
        [InlineData("", "2", 2)]
        [InlineData("1", "1", 2)]
        [InlineData("11", "11", 22)]
        [InlineData("111", "111", 222)]

        public void ShouldReturnIntWithSumOfTwoString(string num1, string num2, int answer)
        {
            var sut = new AddNonIntsAsInts();

            int result = sut.SumTwoString(num1, num2);

            Assert.Equal(answer, result);
        }
    }
}
