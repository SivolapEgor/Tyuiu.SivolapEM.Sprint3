using Tyuiu.SivolapEM.Sprint3.Task6.V16.Lib;

namespace Tyuiu.SivolapEM.Sprint3.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            int startValue = 17;
            int stopValue = 26;

            double wait = 41;
            double res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
