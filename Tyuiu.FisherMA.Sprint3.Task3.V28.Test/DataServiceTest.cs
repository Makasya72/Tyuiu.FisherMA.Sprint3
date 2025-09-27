using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FisherMA.Sprint3.Task3.V28.Lib;

namespace Tyuiu.FisherMA.Sprint3.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReplaceNumOnCharTest()
        {
            DataService ds = new DataService();
            string value = "f35hyt t4j 3gkg45";
            char item = 'r';
            string wait = "frrhyt trj rgkgrr";

            string res = ds.ReplaceNumOnChar(value, item);
            Assert.AreEqual(wait, res);
        }
    }
}