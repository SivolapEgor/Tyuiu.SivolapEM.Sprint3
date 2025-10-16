using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SivolapEM.Sprint3.Task2.V13.Lib
{
    public class DataService : ISprint3Task2V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                return 0;
            }

            double sumOfTerms = 0;
            int k = startValue;

            do
            {
                double currentTerm = Math.Pow(value, k) + 2.0 / (k + 1);
                sumOfTerms += currentTerm;

                k++;

            } while (k <= stopValue);

            double finalSum = sumOfTerms * Math.Sin(value);

            return Math.Round(finalSum, 3);
        }
    }
}
