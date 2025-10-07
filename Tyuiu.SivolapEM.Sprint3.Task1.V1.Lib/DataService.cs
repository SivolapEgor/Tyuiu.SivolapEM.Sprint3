using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SivolapEM.Sprint3.Task1.V1.Lib
{
    public class DataService : ISprint3Task1V1
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                p *= (Math.Pow(k, 2) / 9.0);
                k++;
            }

            return Math.Round(p, 3);
        }
    }
}
