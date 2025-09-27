using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FisherMA.Sprint3.Task2.V20.Lib;

namespace Tyuiu.FisherMA.Sprint3.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesTest()
        {
            DataService ds = new DataService();

            double x = 1;
            int Start = 1;
            int End = 6;
            double wait = 0.667; 

            double res = ds.GetMultiplySeries(x, Start, End);
            Assert.AreEqual(wait, res);
        }
    }
}