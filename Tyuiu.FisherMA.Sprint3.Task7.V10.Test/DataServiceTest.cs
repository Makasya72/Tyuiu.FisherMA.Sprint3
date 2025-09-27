using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FisherMA.Sprint3.Task7.V10.Lib;

namespace Tyuiu.FisherMA.Sprint3.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetTabFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetTabFunction(startValue, stopValue);
            double[] wait = { -8.18, -6.46, -4.61, -2.75, -1.03, 0.83, 2.42, 3.72, 4.81, 5.74, 6.56 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}