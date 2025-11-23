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
            string wait = "Зима";
            string res = ds.FindMonthSeason(month);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonthSeason_Spring()
        {
            DataService ds = new DataService();
            int month = 4;
            string wait = "Весна";
            string res = ds.FindMonthSeason(month);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonthSeason_Summer()
        {
            DataService ds = new DataService();
            int month = 7;
            string wait = "Лето";
            string res = ds.FindMonthSeason(month);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonthSeason_Autumn()
        {
            DataService ds = new DataService();
            int month = 10;
            string wait = "Осень";
            string res = ds.FindMonthSeason(month);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonthSeason_December()
        {
            DataService ds = new DataService();
            int month = 12;
            string wait = "Зима";
            string res = ds.FindMonthSeason(month);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonthSeason_February()
        {
            DataService ds = new DataService();
            int month = 2;
            string wait = "Зима";
            string res = ds.FindMonthSeason(month);
            Assert.AreEqual(wait, res);
        }
    }
}