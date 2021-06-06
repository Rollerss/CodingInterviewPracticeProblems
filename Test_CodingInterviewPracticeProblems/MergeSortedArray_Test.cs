using CodingInterviewPracticeProblems;
using Xunit;

namespace Test_CodingInterviewPracticeProblems
{
    public class MergeSortedArray_Test
    {
        [Theory]
        [InlineData(new int[] { 2, 4, 6 }, new int[] { 1, 3, 5 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new int[] { 2, 4, 6, 7 }, new int[] { 1, 3, 5 }, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [InlineData(new int[] { 2, 4, 6, 6 }, new int[] { 1, 3, 5 }, new int[] { 1, 2, 3, 4, 5, 6, 6 })]
        [InlineData(new int[] { }, new int[] { 1, 3, 5 }, new int[] { 1, 3, 5 })]
        [InlineData(new int[] { 2, 4, 6 }, new int[] { }, new int[] { 2, 4, 6 })]
        public void Test1(int[] arr1, int[] arr2, int[] answer)
        {
            var sut = new MergeSortedArrays();

            var combindedArr = sut.MergeSortedArray(arr1, arr2);

            Assert.Equal(answer, combindedArr);

        }
    }
}
