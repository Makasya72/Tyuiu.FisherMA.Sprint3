using Tyuiu.FisherMA.Sprint3.Task0.V3.Lib;


namespace Tyuiu.FisherMA.Sprint3.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSeries(1, 10);

            double expected = 0.593;
            Assert.AreEqual(expected, res);
        }
    }
}