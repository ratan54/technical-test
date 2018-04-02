namespace TechnicalTestCore
{
    public class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int result = 0;
            for (int i = 1; i <= maxNrAsInt; i++)
            {
                result = result + i;
            }

            return result;
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            long result = 0;
            for (long i = 1; i <= System.Convert.ToInt64(maxNrAsString); i++)
            {
                result = result + i;
            }

            return result.ToString();
        }
    }
}
