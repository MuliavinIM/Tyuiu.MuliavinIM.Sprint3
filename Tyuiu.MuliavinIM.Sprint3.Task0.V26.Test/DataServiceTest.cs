using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MuliavinIM.Sprint3.Task0.V26.Lib;

namespace Tyuiu.MuliavinIM.Sprint3.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();

            double res = ds.GetMultiplySeries(1, 9);

            double expected = -116204.5749;

            Assert.AreEqual(expected, Math.Round(res, 4));
        }
    }
}
