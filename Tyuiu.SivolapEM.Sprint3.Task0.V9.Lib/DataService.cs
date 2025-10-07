using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SivolapEM.Sprint3.Task0.V9.Lib
{
    public class DataService : ISprint3Task0V9
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            if (startValue > stopValue) return 0.0;

            double sum = 0.0;

            for (int i = startValue; i <= stopValue; i++)
            {
                double denominator = 3 + Math.Pow(value, i);

                if (denominator == 0) continue;

                double termBase = 1.0 / denominator;

                double currentTerm = Math.Pow(termBase, i);
                sum += currentTerm;
            }

            return Math.Round(sum, 3);
        }
    }
}
