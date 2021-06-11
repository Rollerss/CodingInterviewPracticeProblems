using System;
using System.Linq;

namespace CodingInterviewPracticeProblems
{
    public class ReveresWordOrderInString
    {
        public string ReveresWordOrderBuiltIns(string str)
        {
            if (str.Length < 2 || !str.Contains(" "))
            {
                return str;
            }

            return string.Join(" ", str.Split(" ").Reverse());
        }

        public string ReveresWordOrder(string str)
        {
            if (str.Length < 2 || !str.Contains(" "))
            {
                return str;
            }

            var arr = str.Split(" ");

            string newStr = "";

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                newStr += arr[i];

                if (i != 0)
                {
                    newStr += " ";
                }
            }

            return newStr.Trim();
        }
    }
}
