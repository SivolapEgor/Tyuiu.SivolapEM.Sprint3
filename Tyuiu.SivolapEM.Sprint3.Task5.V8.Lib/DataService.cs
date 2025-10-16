using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SivolapEM.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    double sin_k = Math.Sin(k);

                    if (sin_k == 0)
                    {
                        throw new DivideByZeroException($"Попытка деления на ноль: sin(k) равен нулю при k = {k}.");
                    }

                    totalSum += 1.0 / sin_k;
                }
            }

            return Math.Round(totalSum, 3);
        }
    }
}
