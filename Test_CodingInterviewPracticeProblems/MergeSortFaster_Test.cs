using CodingInterviewPracticeProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Test_CodingInterviewPracticeProblems
{
    public class MergeSortFaster_Test
    {
        private readonly ITestOutputHelper output;

        public MergeSortFaster_Test(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [InlineData(new int[] { 2, 4, 6, 1, 3, 5 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new int[] { 2, 4, 6, 7, 1, 3, 5 }, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [InlineData(new int[] { 2, 4, 6, 6, 1, 3, 5 }, new int[] { 1, 2, 3, 4, 5, 6, 6 })]
        [InlineData(new int[] { 1, 3, 5 }, new int[] { 1, 3, 5 })]
        [InlineData(new int[] { 2, 4, 6 }, new int[] { 2, 4, 6 })]
        public void FasterMergeSort(int[] arr1, int[] answer)
        {
            var sut = new MergeSortFaster();

            var combindedArr = sut.FasterMergeSort(arr1);

            Assert.Equal(answer, combindedArr);

        }

        [Theory]
        [InlineData(new int[] { 2, 4, 6, 1, 3, 5 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new int[] { 2, 4, 6, 7, 1, 3, 5 }, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [InlineData(new int[] { 2, 4, 6, 6, 1, 3, 5 }, new int[] { 1, 2, 3, 4, 5, 6, 6 })]
        [InlineData(new int[] { 1, 3, 5 }, new int[] { 1, 3, 5 })]
        [InlineData(new int[] { 2, 4, 6 }, new int[] { 2, 4, 6 })]
        public void FasterMergeSort2(int[] arr1, int[] answer)
        {
            var sut = new MergeSortFaster();

            var combindedArr = sut.FasterMergeSort2(arr1);

            Assert.Equal(answer, combindedArr);

        }
    }
}
