using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint2.Task4.V5.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate_WhenXGreaterThanYPlus5()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 2;
            double wait = 2 * Math.Pow((10 + 2) / (2 + 5), 10);
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate_WhenXNotGreaterThanYPlus5()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            double wait = Math.Pow(5, 2) + 10 * 5 + (1 / 10.0);
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate_BorderCase()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double wait = Math.Pow(10, 2) + 10 * 10 + (1 / 5.0);
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}