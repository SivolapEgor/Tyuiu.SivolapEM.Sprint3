using Tyuiu.SivolapEM.Sprint3.Task4.V12.Lib;

namespace Tyuiu.SivolapEM.Sprint3.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            var ds = new DataService();
            int start = -5;
            int stop = 5;
            double expected = 467.59;

            double actual = ds.Calculate(start, stop);

            Assert.AreEqual(expected, actual);
        }
    }
}
