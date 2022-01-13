using CodingInterviewPracticeProblems;
using Xunit;

namespace Test_CodingInterviewPracticeProblems
{
    public class Anagrams_Test
    {
        [Theory]
        [InlineData("abc", "cba", true)]
        [InlineData("danger", "garden", true)]
        [InlineData("aab", "bba", false)]
        [InlineData("aab", "ba", false)]
        public void ShouldReturnIfTwoStringsAreAnagramsDict(string strOne, string strTwo, bool expected)
        {
            var sut = new Anagrams();
            bool result = sut.AreStringsAnagrams(strOne, strTwo);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abc", "cba", true)]
        [InlineData("danger", "garden", true)]
        [InlineData("aab", "bba", false)]
        [InlineData("aab", "ba", false)]
        public void ShouldReturnIfTwoStringsAreAnagramsHash(string strOne, string strTwo, bool expected)
        {
            var sut = new Anagrams();
            bool result = sut.AreTwoStringsAnagrams(strOne, strTwo);
            Assert.Equal(expected, result);
        }
    }
}
