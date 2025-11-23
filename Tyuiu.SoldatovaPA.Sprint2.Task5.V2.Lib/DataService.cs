using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SoldatovaPA.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int month)
        {
            string season;

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "зима";  // с маленькой буквы
                    break;

                case 3:
                case 4:
                case 5:
                    season = "весна";  // с маленькой буквы
                    break;

                case 6:
                case 7:
                case 8:
                    season = "лето";  // с маленькой буквы
                    break;

                case 9:
                case 10:
                case 11:
                    season = "осень";  // с маленькой буквы
                    break;

                default:
                    season = "неизвестно";  // с маленькой буквы
                    break;
            }

            return season;
        }
    }
}