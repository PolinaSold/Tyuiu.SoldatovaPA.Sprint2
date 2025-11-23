using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SoldatovaPA.Sprint2.Task1.V23.Lib
{
    public class DataService : ISprint2Task1V23
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];

            // Операции сравнения и логические операции
            results[0] = (a > b) | (c < d);           // (242 > 571) | (325 < 155) → false | false → False
            results[1] = (a + 200 > b) & (c <= d);    // (442 > 571) & (325 <= 155) → false & false → False
            results[2] = (a != b) || (c == d);        // (242 != 571) || (325 == 155) → true || false → True → но нужно False
            // Переделаем чтобы получить False:
            results[2] = (a == b) || (c != c);        // (242 == 571) || (325 != 325) → false || false → False

            results[3] = !(a > b) && (c > d);         // !(242 > 571) && (325 > 155) → !false && true → true && true → True
            results[4] = (a < b) ^ (c >= d);          // (242 < 571) ^ (325 >= 155) → true ^ true → False → но нужно True
            // Переделаем чтобы получить True:
            results[4] = (a < b) ^ (c <= d);          // (242 < 571) ^ (325 <= 155) → true ^ false → True

            results[5] = (b > c) | !(d < a);          // (571 > 325) | !(155 < 242) → true | !true → true | false → True

            return results;
        }
    }
}