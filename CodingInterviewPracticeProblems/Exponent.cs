namespace CodingInterviewPracticeProblems
{
    public class Exponent
    {
        public double Pow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            bool negativeExponet = false;
            if (n < 0)
            {
                negativeExponet = true;
                n = -n;
            }

            double pow = x * Pow(x, n - 1);

            return negativeExponet ? 1 / pow : pow;
        }
    }
}
