using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SoldatovaPA.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int month)
        {
            string season;

            // Оператор switch для определения времени года
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Зима";
                    break;

                case 3:
                case 4:
                case 5:
                    season = "Весна";
                    break;

                case 6:
                case 7:
                case 8:
                    season = "Лето";
                    break;

                case 9:
                case 10:
                case 11:
                    season = "Осень";
                    break;

                default:
                    season = "Неизвестно";
                    break;
            }

            return season;
        }
    }
}