using Tyuiu.FisherMA.Sprint3.Task0.V3.Lib;

namespace Tyuiu.FisherMA.Sprint3.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateSeriesTest()
        {
            DataService ds = new DataService();
            double res = ds.CalculateSeries();

            double expected = 0.353;
            Assert.AreEqual(expected, res);
        }
    }
}