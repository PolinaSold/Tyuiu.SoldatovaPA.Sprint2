using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SoldatovaPA.Sprint2.Task0.V17.Lib
{
    public class DataService : ISprint2Task0V17
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results = new bool[6];

            // Операции сравнения в заданной последовательности
            results[0] = x == y + 310;    // 1065 == 755 + 310 → 1065 == 1065 → True
            results[1] = x != y + 310;    // 1065 != 1065 → False
            results[2] = x < y;           // 1065 < 755 → False
            results[3] = x > y + 500;     // 1065 > 755 + 500 → 1065 > 1255 → False
            results[4] = x <= y;          // 1065 <= 755 → False
            results[5] = x >= y + 500;    // 1065 >= 1255 → False

            return results;
        }
    }
}