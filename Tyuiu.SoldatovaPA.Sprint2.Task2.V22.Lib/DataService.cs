using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SoldatovaPA.Sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // Основная "Голова" (Верхняя часть)
            bool head = false;

            // Верхние квадраты Y=3,4,5
            if ((y == 3 || y == 4 || y == 5) &&
                ((x >= 3 && x <= 5) || (x >= 9 && x <= 11)))
            {
                head = true;
            }

            // Соединяющая и центральная часть
            if ((y == 6 || y == 7) && (x >= 3 && x <= 11))
            {
                head = true;
            }

            if (y == 8 && (x >= 3 && x <= 10))
            {
                head = true;
            }

            if ((y == 9 || y == 10) && (x >= 3 && x <= 8))
            {
                head = true;
            }

            if (y == 11 && (x >= 3 && x <= 5))
            {
                head = true;
            }

            // Левый "Ус"
            bool leftWhisker = false;
            if ((y == 4 || y == 10) && x == 2)
            {
                leftWhisker = true;
            }

            if (y == 12 && x == 3)
            {
                leftWhisker = true;
            }

            // Нижняя "Подставка"
            bool basePart = false;
            if (y == 13 && (x >= 3 && x <= 12))
            {
                basePart = true;
            }

            return head || leftWhisker || basePart;
        }
    }
}