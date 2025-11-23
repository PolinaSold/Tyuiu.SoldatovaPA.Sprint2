using System;
using Tyuiu.SoldatovaPA.Sprint2.Task0.V17.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task0.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №2 | Вариант 17 | ИСПБ-25-1                  *");
            Console.WriteLine("* Операции сравнения                              *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                        *");
            Console.WriteLine("* Написать программу из операций сравнений        *");
            Console.WriteLine("* (==, !=, <, >, <=, >=), которая вернет         *");
            Console.WriteLine("* логическую последовательность:                  *");
            Console.WriteLine("* (True, False, False, False, False, False)       *");
            Console.WriteLine("* при x = 1065, y = 755                           *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                *");
            Console.WriteLine("***************************************************");

            int x = 1065;
            int y = 755;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            Console.WriteLine("***************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                     *");
            Console.WriteLine("***************************************************");

            bool[] results = ds.GetCompareOperations(x, y);

            Console.Write("Логическая последовательность: (");
            for (int i = 0; i < results.Length; i++)
            {
                Console.Write(results[i]);
                if (i < results.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(")");

            Console.ReadKey();
        }
    }
}