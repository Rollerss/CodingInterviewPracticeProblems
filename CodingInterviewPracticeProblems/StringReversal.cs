using System;
using System.Linq;

namespace CodingInterviewPracticeProblems
{
    public class StringReversal
    {
        public string ReverseString(string str)
        {
            int strLength = str.Length;

            if (strLength < 2)
            {
                return str;
            }

            char[] reversedChars = new char[strLength];

            for (int i = 0; i < strLength; i++)
            {
                reversedChars[i] = str[strLength - 1 - i];
            }

            return string.Join("", reversedChars);
        }

        public string FasterReverseString(string str)
        {
            int strLength = str.Length;

            if (strLength < 2)
            {
                return str;
            }

            char[] reversedChars = new char[strLength];

            int reverseIndex = strLength - 1;

            for (int i = 0; i < (strLength + 1) / 2; i++)
            {
                reverseIndex = strLength - 1 - i;

                reversedChars[i] = str[reverseIndex];
                reversedChars[reverseIndex] = str[i];
            }

            return string.Join("", reversedChars);
        }

        public string ReverseStringBuiltIns(string str) =>
            string.Join("", str.Reverse());

    }
}
