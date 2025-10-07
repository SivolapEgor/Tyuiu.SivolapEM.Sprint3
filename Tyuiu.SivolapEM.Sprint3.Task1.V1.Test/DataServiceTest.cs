using Tyuiu.SivolapEM.Sprint3.Task1.V1.Lib;

namespace Tyuiu.SivolapEM.Sprint3.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExperrions()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 7;
            double expected = 5.311;

            double result = ds.GetMultiplySeries(startValue, stopValue);

            Assert.AreEqual(expected, result);
        }
    }
}
