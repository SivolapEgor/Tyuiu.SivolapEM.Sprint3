using Tyuiu.SivolapEM.Sprint3.Task7.V8.Lib;

namespace Tyuiu.SivolapEM.Sprint3.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] expected = new double[]
            {
                -8.86, 
                -7.19,
                -6.14,
                -4.76,
                -2.33, 
                 1.00,
                 4.38,
                 0.00, 
                 6.13,
                 7.07, 
                 8.61 
            };

            double[] actual = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
