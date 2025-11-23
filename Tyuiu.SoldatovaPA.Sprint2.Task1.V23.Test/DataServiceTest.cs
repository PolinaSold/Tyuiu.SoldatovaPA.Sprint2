using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint2.Task1.V23.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 242;
            int b = 571;
            int c = 325;
            int d = 155;

            bool[] wait = { false, false, false, true, true, true };
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetLogicOperations_CheckFirstThreeFalse()
        {
            DataService ds = new DataService();
            int a = 242;
            int b = 571;
            int c = 325;
            int d = 155;

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            // Проверяем что первые три элемента - false
            Assert.IsFalse(res[0]);
            Assert.IsFalse(res[1]);
            Assert.IsFalse(res[2]);
        }

        [TestMethod]
        public void ValidGetLogicOperations_CheckLastThreeTrue()
        {
            DataService ds = new DataService();
            int a = 242;
            int b = 571;
            int c = 325;
            int d = 155;

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            // Проверяем что последние три элемента - true
            Assert.IsTrue(res[3]);
            Assert.IsTrue(res[4]);
            Assert.IsTrue(res[5]);
        }
    }
}