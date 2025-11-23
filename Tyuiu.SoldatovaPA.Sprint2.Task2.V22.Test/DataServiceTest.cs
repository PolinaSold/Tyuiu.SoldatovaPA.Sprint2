using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint2.Task2.V22.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea_InsideHead()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea_InsideBase()
        {
            DataService ds = new DataService();
            int x = 7;
            int y = 13;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea_LeftWhisker()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 10;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea_Outside()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea_BorderCase()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 12;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea_RightSquare()
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}