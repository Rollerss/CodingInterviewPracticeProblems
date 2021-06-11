using CodingInterviewPracticeProblems;
using Xunit;

namespace Test_CodingInterviewPracticeProblems
{
    public class ReveresWordOrderInString_Test
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("a b", "b a")]
        [InlineData("ab ba", "ba ab")]
        [InlineData("ba ba", "ba ba")]
        [InlineData("hello world", "world hello")]
        [InlineData("the apple is red", "red is apple the")]
        [InlineData("the end is near maybe", "maybe near is end the")]
        public void ShouldReturnReversedWordsInStringBuiltIns(string str, string answer)
        {
            var sut = new ReveresWordOrderInString();

            string result = sut.ReveresWordOrderBuiltIns(str);

            Assert.Equal(answer, result);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("a b", "b a")]
        [InlineData("ab ba", "ba ab")]
        [InlineData("ba ba", "ba ba")]
        [InlineData("hello world", "world hello")]
        [InlineData("the apple is red", "red is apple the")]
        [InlineData("the end is near maybe", "maybe near is end the")]
        public void ShouldReturnReversedWordsInString(string str, string answer)
        {
            var sut = new ReveresWordOrderInString();

            string result = sut.ReveresWordOrder(str);

            Assert.Equal(answer, result);
        }
    }
}
