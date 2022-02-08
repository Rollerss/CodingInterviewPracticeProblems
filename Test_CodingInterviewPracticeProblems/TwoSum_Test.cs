using CodingInterviewPracticeProblems;
using Xunit;

namespace Test_CodingInterviewPracticeProblems
{
    public class TwoSum_Test
    {
        [Theory]
        [InlineData(new int[] { 1, 2 }, 3, new int[] { 0, 1 })]
        [InlineData(new int[] { 1, 2, 3 }, 4, new int[] { 0, 2 })]
        [InlineData(new int[] { 1, 2, 3 }, 6, new int[] { 0, 0 })]
        public void ShouldReturnArrayWithIndexOfNumberEqualToSum(int[] numsArr, int sum, int[] sumIndexes)
        {
            var sut = new TwoSum();

            int[] result = sut.GetIndexesTwoNumsEqualTwoSum(numsArr, sum);

            Assert.Equal(sumIndexes, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2 }, 3, new int[] { 0, 1 })]
        [InlineData(new int[] { 1, 2, 3 }, 4, new int[] { 0, 2 })]
        [InlineData(new int[] { 1, 2, 3 }, 6, new int[] { 0, 0 })]
        public void ShouldReturnArrayWithIndexOfNumberEqualToSumConstentTime(int[] numsArr, int sum, int[] sumIndexes)
        {
            var sut = new TwoSum();

            int[] result = sut.GetIndexesTwoNumsEqualTwoSumContentTime(numsArr, sum);

            Assert.Equal(sumIndexes, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2 }, 3, new int[] { 0, 1 })]
        [InlineData(new int[] { 1, 2, 3 }, 4, new int[] { 0, 2 })]
        [InlineData(new int[] { 1, 2, 3 }, 6, new int[] { 0, 0 })]
        public void ShouldReturnArrayWithIndexOfNumberEqualToSumTwoPointers(int[] numsArr, int sum, int[] sumIndexes)
        {
            var sut = new TwoSum();

            int[] result = sut.GetIndexesTwoNumsEqualTwoSumTwoPointersContentTime(numsArr, sum);

            Assert.Equal(sumIndexes, result);
        }
    }
}
