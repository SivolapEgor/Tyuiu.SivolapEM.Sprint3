using Tyuiu.SivolapEM.Sprint3.Task3.V10.Lib;

namespace Tyuiu.SivolapEM.Sprint3.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            var ds = new DataService();
            string value = "gdfppf vfppt p";
            char item = 'p';
            string expected = "gdff vft ";

            string actual = ds.DeleteCharInString(value, item);

            Assert.AreEqual(expected, actual);
        }
    }
}
