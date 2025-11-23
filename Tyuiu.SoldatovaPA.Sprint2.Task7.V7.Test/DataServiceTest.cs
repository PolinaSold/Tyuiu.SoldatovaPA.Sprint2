using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint2.Task7.V7.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точка внутри области (например, (0, 1))
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 1));

            // Точка на границе области
            Assert.IsTrue(ds.CheckDotInShadedArea(1, 1));

            // Точка вне области (ниже параболы)
            Assert.IsFalse(ds.CheckDotInShadedArea(0, 0));

            // Точка вне области (выше прямой)
            Assert.IsFalse(ds.CheckDotInShadedArea(0, 2));

            // Точка на пересечении графиков
            Assert.IsTrue(ds.CheckDotInShadedArea(-2, -2)); // Решение уравнения 2 - x² = x
        }
    }
}