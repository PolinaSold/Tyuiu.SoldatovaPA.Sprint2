using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint2.Task3.V16.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate_XGreaterThan1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 2 + Math.Pow((2 + 1) / (2 - 1), 3); // 2 + 27 = 29
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate_XEquals0()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 2 * 0 - Math.Cos(0) + 10; // 0 - 1 + 10 = 9
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate_XBetweenMinus20And2()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 1 + (1 / Math.Pow(1, 2)); // 1 + 1 = 2
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate_XLessThanMinus20()
        {
            DataService ds = new DataService();
            double x = -25;
            double wait = -25 + 10 * (-25) - (1 / (-25)); // -25 - 250 + 0.04 = -274.96
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate_XLessThan2()
        {
            DataService ds = new DataService();
            double x = -5;
            double wait = 5 * Math.Pow(-5, 2) - Math.Sin(Math.Pow(-5, 2)) + 12; // 125 - sin(25) + 12
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}