using CodingInterviewPracticeProblems;
using Xunit;

namespace Test_CodingInterviewPracticeProblems
{
    public class StringReversal_Test
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("abba", "abba")]
        [InlineData("abab", "baba")]
        [InlineData("abbbgbbaa", "aabbgbbba")]
        [InlineData("abbbggbbaa", "aabbggbbba")]
        [InlineData("abcabc", "cbacba")]
        public void ShouldReturnReverseString(string str, string answer)
        {
            var sut = new StringReversal();

            string result = sut.ReverseString(str);

            Assert.Equal(answer, result);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("abba", "abba")]
        [InlineData("abab", "baba")]
        [InlineData("abbbgbbaa", "aabbgbbba")]
        [InlineData("abbbggbbaa", "aabbggbbba")]
        [InlineData("abcabc", "cbacba")]
        public void ShouldReturnReverseStringFaster(string str, string answer)
        {
            var sut = new StringReversal();

            string result = sut.FasterReverseString(str);

            Assert.Equal(answer, result);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("abba", "abba")]
        [InlineData("abab", "baba")]
        [InlineData("abbbgbbaa", "aabbgbbba")]
        [InlineData("abbbggbbaa", "aabbggbbba")]
        [InlineData("abcabc", "cbacba")]
        public void ShouldReturnReverseStringUsingBuiltIns(string str, string answer)
        {
            var sut = new StringReversal();

            string result = sut.FasterReverseString(str);

            Assert.Equal(answer, result);
        }
    }
}
