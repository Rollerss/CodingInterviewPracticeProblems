using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewPracticeProblems
{
    public class DivideTwoInts
    {
        public int DivideTheLongWay(int divided, int divisor)
        {
            int count = 0;
            while (divided > 0)
            {
                divided -= divisor;
                if (divided >= 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
