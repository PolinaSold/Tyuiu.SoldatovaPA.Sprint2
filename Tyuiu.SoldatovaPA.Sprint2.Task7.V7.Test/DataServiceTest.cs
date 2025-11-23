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

            // Точки ВНУТРИ области
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 1));    // Центр области
            Assert.IsTrue(ds.CheckDotInShadedArea(-1, 0.5)); // Левая часть
            Assert.IsTrue(ds.CheckDotInShadedArea(0.5, 0.7)); // Правая часть

            // Точки на ГРАНИЦАХ
            Assert.IsTrue(ds.CheckDotInShadedArea(-2, -2)); // Левое пересечение
            Assert.IsTrue(ds.CheckDotInShadedArea(1, 1));   // Правое пересечение
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 2));   // На параболе

            // Точки ВНЕ области
            Assert.IsFalse(ds.CheckDotInShadedArea(0, 0));   // Ниже прямой
            Assert.IsFalse(ds.CheckDotInShadedArea(0, 3));   // Выше параболы
            Assert.IsFalse(ds.CheckDotInShadedArea(-3, 0));  // x < -2
            Assert.IsFalse(ds.CheckDotInShadedArea(2, 0));   // x > 1
            Assert.IsFalse(ds.CheckDotInShadedArea(-1, -1)); // Ниже прямой
        }
    }
}