using System.Collections.Generic;

namespace CodingInterviewPracticeProblems
{
    public class TwoSum
    {
        public int[] GetIndexesTwoNumsEqualTwoSum(int[] numsArr, int sum)
        {
            for (int i = 0; i < numsArr.Length; i++)
            {
                for (int j = i + 1; j < numsArr.Length; j++)
                {
                    if (numsArr[i] + numsArr[j] == sum)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[2];
        }

        public int[] GetIndexesTwoNumsEqualTwoSumContentTime(int[] numsArr, int sum)
        {
            // used a dictionary because the need to return the index
            Dictionary<int, int> lookup = new();

            for (int i = 0; i < numsArr.Length; i++)
            {
                if (lookup.ContainsKey(sum - numsArr[i]))
                {
                    return new int[] { lookup[sum - numsArr[i]], i };
                }
                if (!lookup.ContainsKey(numsArr[i]))
                {
                    lookup[numsArr[i]] = i;
                }
            }


            return new int[2];
        }
    }
}
