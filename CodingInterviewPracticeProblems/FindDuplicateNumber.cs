using System.Collections.Generic;
using System.Linq;

namespace CodingInterviewPracticeProblems
{
    public class FindDuplicateNumber
    {
        public int FindDuplicateNumberInArray(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>();

            foreach (var num in nums)
            {
                if (numSet.Contains(num))
                {
                    return num;
                }
                numSet.Add(num);
            }

            return 0;
        }

        public int FindDuplicateNumberInArrayForeachLinq(int[] nums)
        {
            foreach (var num in nums)
            {
                if (nums.Count(n => n == num) > 1)
                {
                    return num;
                }
            }

            return 0;
        }

        public int FindDuplicateNumberInArrayLinq2(int[] nums)
        {
            return nums.GroupBy(x => x)
                       .Where(n => n.Count() > 1)
                       .Select(g => g.Key)
                       .FirstOrDefault();
        }
    }
}
