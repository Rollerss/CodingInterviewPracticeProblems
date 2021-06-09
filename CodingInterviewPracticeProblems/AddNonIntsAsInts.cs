namespace CodingInterviewPracticeProblems
{
    public class AddNonIntsAsInts
    {
        public int SumTwoString(string num1, string num2)
        {
            return StringToInt(num1) + StringToInt(num2);
        }

        private int StringToInt(string num)
        {
            int len = num.Length;
            int value = 0;

            Exponent exponet = new Exponent();
            for (int i = 0; i < len; i++)
            {
                int place = (int)exponet.Pow(10, i);
                value += CharToInt(num[i]) * place;
            }

            return value;
        }

        private int CharToInt(char c)
        {
            return c switch
            {
                '0' => 0,
                '1' => 1,
                '2' => 2,
                '3' => 3,
                '4' => 4,
                '5' => 5,
                '6' => 6,
                '7' => 7,
                '8' => 8,
                '9' => 9,
                _ => 0,
            };
        }
    }
}
