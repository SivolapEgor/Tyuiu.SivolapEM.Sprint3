using Tyuiu.SivolapEM.Sprint3.Task0.V9.Lib;

namespace Tyuiu.SivolapEM.Sprint3.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            var ds = new DataService();
            double x = 0.5;
            double expected = 0.43;

            double actual = ds.GetSumSeries(x, 1, 15);

            Assert.AreEqual(expected, actual);
        }
    }
}
