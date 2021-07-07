using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingInterviewPracticeProblems
{
    public class ThreeSum
    {
        public int[][] GetTripletsEqualToZero(int[] arrNums)
        {
            HashSet<int[]> arrAnsw = new HashSet<int[]>();

            int arrLen = arrNums.Length;

            for (int i = 0; i < arrLen; i++)
            {
                for (int j = i + 1; j < arrLen; j++)
                {
                    for (int k = j + 1; k < arrLen; k++)
                    {
                        if (arrNums[i] + arrNums[j] + arrNums[k] == 0)
                        {
                            int[] answ = { arrNums[i], arrNums[j], arrNums[k] };
                            Array.Sort(answ);
                            if (!arrAnsw.Any(a => a.SequenceEqual(answ)))
                            {
                                arrAnsw.Add(answ);
                            }
                        }
                    }
                }
            }

            return arrAnsw.ToArray();
        }

    }
}
