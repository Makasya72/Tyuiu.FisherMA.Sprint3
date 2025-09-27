
using Tyuiu.FisherMA.Sprint3.Task1.V22.Lib;

namespace Tyuiu.FisherMA.Sprint3.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeriesTest()
        {
            DataService ds = new DataService();

            double a = 1.5;
            int Start = 1;
            int End = 20;
            double wait = -1.567; 

            double res = ds.GetSumSeries(a, Start, End);
            Assert.AreEqual(wait, res);
        }
    }
}