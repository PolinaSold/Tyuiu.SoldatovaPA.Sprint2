using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SoldatovaPA.Sprint2.Task4.V5.Lib
{
    public class DataService : ISprint2Task4V5
    {
        public double Calculate(double x, double y)
        {
            // Тернарный оператор
            double z = (x > y + 5)
                ? y * Math.Pow((x + 2) / (y + 5), x)  // если x > y + 5
                : Math.Pow(x, 2) + 10 * x + (1 / y);  // иначе

            return Math.Round(z, 3);
        }
    }
}