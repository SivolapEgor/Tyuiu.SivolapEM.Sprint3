using Tyuiu.SivolapEM.Sprint3.Task2.V13.Lib;

namespace Tyuiu.SivolapEM.Sprint3.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            var ds = new DataService();
            double t = 0.7;
            int start = 1;
            int stop = 10;
            double expected = 4.063;

            double actual = ds.GetSumSeries(t, start, stop);

            Assert.AreEqual(expected, actual);
        }
    }
}
