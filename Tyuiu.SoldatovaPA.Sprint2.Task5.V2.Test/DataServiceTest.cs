using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint2.Task5.V2.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeason_Winter()
        {
            DataService ds = new DataService();
            int month = 1;
            string wait = "зима";  // с маленькой буквы
            string res = ds.FindMonthSeason(month);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonthSeason_Spring()
        {
            DataService ds = new DataService();
            int month = 4;
            string wait = "весна";  // с маленькой буквы
            string res = ds.FindMonthSeason(month);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonthSeason_Summer()
        {
            DataService ds = new DataService();
            int month = 7;
            string wait = "лето";  // с маленькой буквы
            string res = ds.FindMonthSeason(month);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonthSeason_Autumn()
        {
            DataService ds = new DataService();
            int month = 10;
            string wait = "осень";  // с маленькой буквы
            string res = ds.FindMonthSeason(month);
            Assert.AreEqual(wait, res);
        }
    }
}