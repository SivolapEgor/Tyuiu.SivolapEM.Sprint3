using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SivolapEM.Sprint3.Task6.V16.Lib
{
    public class DataService : ISprint3Task6V16
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
