using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint2.Task6.V10.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay_RegularDay()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 5;
            int n = 15;
            string wait = "14.5.2023";
            string res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay_FirstDayOfMonth()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 6;
            int n = 1;
            string wait = "31.5.2023";
            string res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay_FirstDayOfYear()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 1;
            int n = 1;
            string wait = "31.12.2022";
            string res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay_February()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 3;
            int n = 1;
            string wait = "28.2.2023";  // год не високосный
            string res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay_30DayMonth()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 5;
            int n = 1;
            string wait = "30.4.2023";  // апрель имеет 30 дней
            string res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay_31DayMonth()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 8;
            int n = 1;
            string wait = "31.7.2023";  // июль имеет 31 день
            string res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}
