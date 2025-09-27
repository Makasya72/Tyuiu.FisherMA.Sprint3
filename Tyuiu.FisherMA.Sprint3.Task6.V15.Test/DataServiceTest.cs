using Tyuiu.FisherMA.Sprint3.Task6.V15.Lib;

namespace Tyuiu.FisherMA.Sprint3.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 6;
            int stopValue = 15;

            int wait = 186; 
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}