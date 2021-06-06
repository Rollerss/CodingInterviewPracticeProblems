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
    }
}
