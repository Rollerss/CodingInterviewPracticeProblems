using CodingInterviewPracticeProblems;
using System;
using System.Linq;
using Xunit;

namespace Test_CodingInterviewPracticeProblems
{
    public class ThreeSum_Test
    {
        // https://leetcode.com/problems/3sum/
        // Given an integer array nums, return all the triplets[nums[i], nums[j], nums[k]]
        // such that i != j, i != k, and j != k,
        // and nums[i] + nums[j] + nums[k] == 0.
        // Notice that the solution set must not contain duplicate triplets.


        [Theory]
        [InlineData(new int[] { 1, 2, -3 }, new int[] { -3, 1, 2 })]
        [InlineData(new int[] { 1, 2, 3, -4 }, new int[] { -4, 1, 3 })]
        [InlineData(new int[] { 1, 2, 3, -5 }, new int[] { -5, 2, 3, })]
        [InlineData(new int[] { 1, 2, 3, -5, 2 }, new int[] { -5, 2, 3 })]
        [InlineData(new int[] { 1, 2, 3, -5, 2, 4 }, new int[] { -5, 1, 4 }, new int[] { -5, 2, 3 })]
        [InlineData(new int[] { 1, 2, 3, -5, 2, 4 }, new int[] { -5, 2, 3 }, new int[] { -5, 1, 4 })]
        public void ShouldReturnArrayOfArraysEqualToZero(int[] numsArr, params int[][] arrAnswer)
        {
            var sut = new ThreeSum();

            int[][] result = sut.GetTripletsEqualToZero(numsArr);

            foreach (var answer in arrAnswer)
            {
                Assert.Contains(result, a => a.SequenceEqual(answer));
            }

            Assert.Equal(arrAnswer.Length, result.Length);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, -3 }, new int[] { -3, 1, 2 })]
        [InlineData(new int[] { 1, 2, 3, -4 }, new int[] { -4, 1, 3 })]
        [InlineData(new int[] { 1, 2, 3, -5 }, new int[] { -5, 2, 3, })]
        [InlineData(new int[] { 1, 2, 3, -5, 2 }, new int[] { -5, 2, 3 })]
        [InlineData(new int[] { 1, 2, 3, -5, 2, 4 }, new int[] { -5, 1, 4 }, new int[] { -5, 2, 3 })]
        [InlineData(new int[] { 1, 2, 3, -5, 2, 4 }, new int[] { -5, 2, 3 }, new int[] { -5, 1, 4 })]
        public void ShouldReturnArrayOfArraysEqualToZeroBetter(int[] numsArr, params int[][] arrAnswer)
        {
            var sut = new ThreeSum();

            int[][] result = sut.GetTripletsEqualToZeroBetter(numsArr);

            foreach (var answer in arrAnswer)
            {
                Assert.Contains(result, a => a.SequenceEqual(answer));
            }

            Assert.Equal(arrAnswer.Length, result.Length);
        }
    }
}
