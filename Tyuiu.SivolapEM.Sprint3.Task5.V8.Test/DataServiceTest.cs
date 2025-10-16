using Tyuiu.SivolapEM.Sprint3.Task5.V8.Lib;

namespace Tyuiu.SivolapEM.Sprint3.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var service = new DataService();
            double expected = 11.066;
            double actual = service.GetSumSumSeries(1, 1, 3, 12);
            Assert.AreEqual(expected, actual);
        }
    }
}
