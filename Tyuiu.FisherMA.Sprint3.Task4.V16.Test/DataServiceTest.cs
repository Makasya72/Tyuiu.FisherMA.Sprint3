using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FisherMA.Sprint3.Task4.V16.Lib;

namespace Tyuiu.FisherMA.Sprint3.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double wait = -0.001; 
            double res = ds.Calculate(start, end);
            Assert.AreEqual(wait, res);
        }
    }
}