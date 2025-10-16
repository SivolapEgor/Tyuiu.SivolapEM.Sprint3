using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SivolapEM.Sprint3.Task4.V12.Lib
{
    public class DataService : ISprint3Task4V12
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }

                double denominator = x + Math.Sin(x);

                if (denominator == 0)
                {
                    throw new DivideByZeroException($"Деление на ноль при x = {x}");
                }

                double y = x / denominator + 2.5;

                product *= y;
            }

            return Math.Round(product, 3);
        }
    }
}
