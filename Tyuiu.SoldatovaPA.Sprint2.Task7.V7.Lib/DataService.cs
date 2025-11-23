using System;
using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.SoldatovaPA.Sprint2.Task7.V7.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверяем, находится ли точка ВЫШЕ параболы y = 2 - x^2
            bool aboveParabola = y >= 2 - Math.Pow(x, 2);

            // Проверяем, находится ли точка НИЖЕ прямой y = x
            bool belowLine = y <= x;

            // Точка находится в заштрихованной области, если она выше параболы И ниже прямой
            return aboveParabola && belowLine;
        }
    }
}
