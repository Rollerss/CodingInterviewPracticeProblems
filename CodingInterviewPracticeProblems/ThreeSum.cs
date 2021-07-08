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

        public int[][] GetTripletsEqualToZeroBetter(int[] arrNums)
        {
            HashSet<int[]> arrAnsw = new HashSet<int[]>();

            // used a dictionary because the need to return the index
            Dictionary<int, int> lookup = new();


            for (int i = 0; i < arrNums.Length; i++)
            {
                int num = arrNums[i];
                foreach (var (k, v) in lookup)
                {
                    int diff = 0 - num - k;

                    if (lookup.ContainsKey(diff) && lookup[diff] != v)
                    {
                        int[] answ = { num, diff, k };
                        Array.Sort(answ);
                        if (!arrAnsw.Any(a => a.SequenceEqual(answ)))
                        {
                            arrAnsw.Add(answ);
                        }
                    }
                }
                if (!lookup.ContainsKey(arrNums[i]))
                {
                    lookup[arrNums[i]] = i;
                }
            }

            return arrAnsw.ToArray();
        }
    }
}
