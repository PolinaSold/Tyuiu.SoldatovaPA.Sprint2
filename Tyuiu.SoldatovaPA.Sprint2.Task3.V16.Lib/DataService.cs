using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SoldatovaPA.Sprint2.Task3.V16.Lib
{
    public class DataService : ISprint2Task3V16
    {
        public double Calculate(double x)
        {
            double y;

            // Вложенные операторы if-else
            if (x > 1)
            {
                y = x + Math.Pow((x + 1) / (x - 1), 3);
            }
            else
            {
                if (x == 0)
                {
                    y = 2 * Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
                }
                else
                {
                    if (x < 2)
                    {
                        if (x < -20)
                        {
                            y = x + 10 * x - (1 / x);
                        }
                        else
                        {
                            if (-20 < x && x < 2)
                            {
                                y = 1 + (1 / Math.Pow(x, 2));
                            }
                            else
                            {
                                y = 5 * Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
                            }
                        }
                    }
                    else
                    {
                        // Этот случай не должен достигать, так как x > 1 уже обработан
                        y = 0;
                    }
                }
            }

            return Math.Round(y, 3);
        }
    }
}