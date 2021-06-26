using CodingInterviewPracticeProblems;
using Xunit;

namespace Test_CodingInterviewPracticeProblems
{
    public class FindDuplicateNumber_Test
    {
        [Theory]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 0)]
        [InlineData(new int[] { 2, 4, 6, 2 }, 2)]
        [InlineData(new int[] { 3, 1, 2, 3, 4, 5, 6 }, 3)]

        public void ShouldRetureDupNumHashSet(int[] nums, int answer)
        {
            var sut = new FindDuplicateNumber();

            int result = sut.FindDuplicateNumberInArray(nums);

            Assert.Equal(answer, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 0)]
        [InlineData(new int[] { 2, 4, 6, 2 }, 2)]
        [InlineData(new int[] { 3, 1, 2, 3, 4, 5, 6 }, 3)]

        public void ShouldRetureDupNumLinq(int[] nums, int answer)
        {
            var sut = new FindDuplicateNumber();

            int result = sut.FindDuplicateNumberInArrayForeachLinq(nums);

            Assert.Equal(answer, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 0)]
        [InlineData(new int[] { 2, 4, 6, 2 }, 2)]
        [InlineData(new int[] { 3, 1, 2, 3, 4, 5, 6 }, 3)]

        public void ShouldRetureDupNumLinq2(int[] nums, int answer)
        {
            var sut = new FindDuplicateNumber();

            int result = sut.FindDuplicateNumberInArrayLinq2(nums);

            Assert.Equal(answer, result);
        }
    }
}
