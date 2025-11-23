using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint2.Task0.V17.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1065;
            int y = 755;

            bool[] wait = { true, false, false, false, false, false };
            bool[] res = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetCompareOperations_CheckFirstOperation()
        {
            DataService ds = new DataService();
            int x = 1065;
            int y = 755;

            bool[] res = ds.GetCompareOperations(x, y);

            // Проверяем первую операцию: x == y + 310
            Assert.IsTrue(res[0]);
            Assert.AreEqual(1065, y + 310); // 755 + 310 = 1065
        }

        [TestMethod]
        public void ValidGetCompareOperations_CheckAllFalse()
        {
            DataService ds = new DataService();
            int x = 1065;
            int y = 755;

            bool[] res = ds.GetCompareOperations(x, y);

            // Проверяем что все кроме первого - false
            for (int i = 1; i < res.Length; i++)
            {
                Assert.IsFalse(res[i]);
            }
        }
    }
}