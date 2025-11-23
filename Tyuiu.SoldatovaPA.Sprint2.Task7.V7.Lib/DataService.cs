using System;
using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.SoldatovaPA.Sprint2.Task7.V7.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверяем, что точка находится между линиями:
            // - НИЖЕ или НА параболе y = 2 - x²
            // - ВЫШЕ или НА прямой y = x
            // - И в пределах x от -2 до 1

            bool belowParabola = y <= (2 - x * x);
            bool aboveLine = y >= x;
            bool inXRange = (x >= -2) && (x <= 1);

            return belowParabola && aboveLine && inXRange;
        }
    }
}